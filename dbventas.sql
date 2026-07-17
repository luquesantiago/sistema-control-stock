-- ============================================================
-- dbventas — Sistema de control de stock
-- Script de creación de base de datos, procedimientos y datos de prueba.
--
-- Reconstruido a partir del backup original del proyecto: los cuerpos de
-- los procedimientos provienen del Sistema.bak histórico; las tablas se
-- derivaron de las consultas de esos procedimientos y de la capa de datos.
--
-- Requiere: SQL Server 2016 o superior (Express sirve).
-- Uso: ejecutar completo en SSMS. Crea la base "dbventas".
--
-- Usuarios de prueba (contraseña "1234"):
--   admin     → rol admin (acceso completo)
--   empleado  → rol empleado1 (compras)
-- ============================================================

IF DB_ID('dbventas') IS NULL
    CREATE DATABASE dbventas;
GO
USE dbventas;
GO

-- ==================== TABLAS ====================

CREATE TABLE localidades (
    Id_localidad INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);
GO
CREATE TABLE TipoTelefono (
    TipoTelefonoID INT IDENTITY(1,1) PRIMARY KEY,
    Tipo NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE Telefonos (
    idtelefono INT IDENTITY(1,1) PRIMARY KEY,
    TipoTelefonoID INT NOT NULL REFERENCES TipoTelefono(TipoTelefonoID),
    Telefono VARCHAR(20) NOT NULL
);
GO
CREATE TABLE Gmail (
    GmailID INT IDENTITY(1,1) PRIMARY KEY,
    Gmail VARCHAR(100) NOT NULL
);
GO
-- Datos de contacto de clientes y proveedores
CREATE TABLE contacto (
    idcontacto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL,
    GmailID INT NULL REFERENCES Gmail(GmailID),
    idtelefono INT NULL REFERENCES Telefonos(idtelefono),
    tipo_documento VARCHAR(20) NULL,
    numero_documento VARCHAR(20) NULL,
    calle VARCHAR(100) NULL,
    altura INT NULL,
    id_localidad INT NULL REFERENCES localidades(Id_localidad)
);
GO
-- Datos personales de los usuarios del sistema
CREATE TABLE Personas (
    PersonaID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    GmailID INT NULL REFERENCES Gmail(GmailID),
    idtelefono INT NULL REFERENCES Telefonos(idtelefono),
    id_localidad INT NULL REFERENCES localidades(Id_localidad)
);
GO
CREATE TABLE cliente (
    idcliente INT IDENTITY(1,1) PRIMARY KEY,
    fecha_nacimiento DATE NULL,
    idcontacto INT NOT NULL REFERENCES contacto(idcontacto),
    bloqueado BIT NOT NULL DEFAULT 0
);
GO
CREATE TABLE proveedor (
    idproveedor INT IDENTITY(1,1) PRIMARY KEY,
    sector_comercial VARCHAR(50) NULL,
    idcontacto INT NOT NULL REFERENCES contacto(idcontacto),
    bloqueado BIT NOT NULL DEFAULT 0
);
GO
CREATE TABLE categoria (
    idcategoria INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(256) NULL
);
GO
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(MAX) NOT NULL,   -- SHA256(contraseña) + SHA256(usuario), en hexadecimal
    PersonaID INT NULL REFERENCES Personas(PersonaID),
    Nuevo BIT NOT NULL DEFAULT 1,
    bloqueado BIT NOT NULL DEFAULT 0
);
GO
CREATE TABLE Permisos (
    PermisoID INT IDENTITY(1,1) PRIMARY KEY,
    Permiso NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE UsuariosPermisos (
    UserID INT NOT NULL REFERENCES Users(UserID),
    PermisoID INT NOT NULL REFERENCES Permisos(PermisoID)
);
GO
CREATE TABLE FechaInicio (
    UserID INT NOT NULL REFERENCES Users(UserID),
    Fecha DATETIME NOT NULL
);
GO
CREATE TABLE FechaFin (
    UserID INT NOT NULL REFERENCES Users(UserID),
    Fecha DATETIME NOT NULL
);
GO
CREATE TABLE Intentos (
    UserID INT NOT NULL REFERENCES Users(UserID),
    Intentos INT NOT NULL DEFAULT 0
);
GO
-- Historial para impedir reutilizar contraseñas
CREATE TABLE HistorialContrasenas (
    UserID INT NOT NULL REFERENCES Users(UserID),
    Password NVARCHAR(MAX) NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE()
);
GO
-- Catálogo de preguntas de seguridad y respuesta elegida por cada usuario
CREATE TABLE PreguntasSeguridad (
    PreguntaID INT IDENTITY(1,1) PRIMARY KEY,
    Pregunta NVARCHAR(100) NOT NULL
);
GO
CREATE TABLE RespuestaSeguridad (
    UserID INT NOT NULL REFERENCES Users(UserID),
    Pregunta NVARCHAR(100) NOT NULL,
    Respuesta NVARCHAR(100) NOT NULL
);
GO
-- Configuración de políticas de contraseña (una sola fila)
CREATE TABLE ConfiguracionSistema (
    Minchar BIT NOT NULL DEFAULT 0,
    MayusyMin BIT NOT NULL DEFAULT 0,
    Especiales BIT NOT NULL DEFAULT 0,
    Validacion BIT NOT NULL DEFAULT 0,
    RepetirC BIT NOT NULL DEFAULT 0
);
GO
CREATE TABLE articulo (
    idarticulo INT IDENTITY(1,1) PRIMARY KEY,
    codigo VARCHAR(50) NULL,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(1024) NULL,
    idcategoria INT NOT NULL REFERENCES categoria(idcategoria),
    idproveedor INT NOT NULL REFERENCES proveedor(idproveedor),
    puntodereaprovisionamiento INT NOT NULL DEFAULT 0,
    stock INT NOT NULL DEFAULT 0,
    precio_compra MONEY NOT NULL DEFAULT 0,
    precio_venta MONEY NOT NULL DEFAULT 0,
    discontinuado BIT NOT NULL DEFAULT 0
);
GO
CREATE TABLE ingreso (
    idingreso INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID),
    idproveedor INT NOT NULL REFERENCES proveedor(idproveedor),
    fecha DATE NOT NULL,
    idarticulo INT NOT NULL REFERENCES articulo(idarticulo),
    cantidad INT NOT NULL,
    total MONEY NOT NULL,
    fecha_produccion DATE NULL,
    fecha_vencimiento DATE NULL,
    anulado BIT NOT NULL DEFAULT 0
);
GO
-- Ingresos confirmados (comprobante recibido)
CREATE TABLE ingreso_realizado (
    id INT IDENTITY(1,1) PRIMARY KEY,
    idingreso INT NOT NULL REFERENCES ingreso(idingreso),
    fecha DATE NOT NULL,
    tipo_compobante VARCHAR(20) NULL,   -- [sic] nombre original de la columna
    numero_comprobante INT NULL
);
GO
CREATE TABLE venta (
    idventa INT IDENTITY(1,1) PRIMARY KEY,
    idcliente INT NOT NULL REFERENCES cliente(idcliente),
    UserID INT NOT NULL REFERENCES Users(UserID),
    fecha DATE NOT NULL,
    tipo_comprobante VARCHAR(20) NULL,
    numero_comprobante INT NULL,
    idarticulo INT NOT NULL REFERENCES articulo(idarticulo),
    cantidad INT NOT NULL,
    total MONEY NOT NULL,
    anulado BIT NOT NULL DEFAULT 0,
    -- columnas legadas usadas por spreporte_factura
    serie VARCHAR(20) NULL,
    correlativo VARCHAR(20) NULL,
    igv DECIMAL(5,2) NULL
);
GO
-- Tablas legadas (las usan spreporte_factura y spmostrar_stock_articulo)
CREATE TABLE detalle_ingreso (
    iddetalle_ingreso INT IDENTITY(1,1) PRIMARY KEY,
    idingreso INT NOT NULL REFERENCES ingreso(idingreso),
    idarticulo INT NOT NULL REFERENCES articulo(idarticulo),
    stock_inicial INT NOT NULL DEFAULT 0,
    precio_venta MONEY NOT NULL DEFAULT 0
);
GO
CREATE TABLE detalle_venta (
    iddetalle_venta INT IDENTITY(1,1) PRIMARY KEY,
    idventa INT NOT NULL REFERENCES venta(idventa),
    iddetalle_ingreso INT NOT NULL REFERENCES detalle_ingreso(iddetalle_ingreso),
    cantidad INT NOT NULL,
    precio_venta MONEY NOT NULL
);
GO
CREATE TABLE trabajador (
    idtrabajador INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(20) NULL, apellidos VARCHAR(40) NULL, sexo VARCHAR(1) NULL,
    fecha_nac DATE NULL, num_documento VARCHAR(8) NULL, direccion VARCHAR(100) NULL,
    telefono VARCHAR(10) NULL, email VARCHAR(50) NULL, acceso VARCHAR(20) NULL,
    usuario VARCHAR(20) NULL, password VARCHAR(20) NULL
);
GO

-- ==================== PROCEDIMIENTOS ALMACENADOS ====================
-- Los cuerpos provienen del Sistema.bak original. Los marcados como
-- [RECONSTRUIDO] estaban truncados en el backup y se reconstruyeron a
-- partir de cómo los consume la capa de datos (datos/*.cs).

-- ---------- Localidades ----------
CREATE OR ALTER PROC spmostrar_localidad
AS
BEGIN
    -- [RECONSTRUIDO] se usa para poblar los combos de localidad
    SELECT Nombre FROM localidades ORDER BY Nombre;
END
GO

-- ---------- Categorías ----------
CREATE OR ALTER PROC spmostrar_categoria
AS
select top 200 * from categoria
order by idcategoria desc
GO

CREATE OR ALTER PROC spinsertar_categoria
@nombre varchar(50),
@descripcion varchar(256)
AS
insert into categoria (nombre,descripcion)
values (@nombre,@descripcion)
GO

CREATE OR ALTER PROC speditar_categoria
@idcategoria int,
@nombre varchar(50),
@descripcion varchar(256)
AS
update categoria set nombre=@nombre,
descripcion=@descripcion
where idcategoria=@idcategoria
GO

CREATE OR ALTER PROC speliminar_categoria
@idcategoria int
AS
delete from categoria
where idcategoria=@idcategoria
GO

CREATE OR ALTER PROC spbuscar_categoria
@textobuscar varchar(50)
AS
select * from categoria
where nombre like '%'+ @textobuscar + '%'
GO

-- ---------- Clientes ----------
CREATE OR ALTER PROC spmostrar_cliente
AS
select top 100 c.idcliente, co.Nombre,bloqueado, fecha_nacimiento, co.tipo_documento, co.numero_documento,
altura, calle,g.Gmail,t.Telefono
from cliente c
inner join  contacto co on c.idcontacto = co.idcontacto
inner join Gmail G on co.GmailID = G.GmailID
INNER JOIN Telefonos T ON co.idtelefono = T.idtelefono
where c.bloqueado=0
order by co.Nombre asc
GO

CREATE OR ALTER PROC spinsertar_cliente
@nombre varchar(50),
@fecha_nacimiento date,
@tipo_documento varchar(20),
@num_documento varchar(11),
@telefono varchar(10),
@gmail varchar(50),
@calle varchar(50),
@altura int,
@localidad varchar(50)
AS
declare @telefonoid int, @idcontacto int,@GmailID INT;
DECLARE @idloclidad int;
SELECT @idloclidad = Id_localidad from localidades where Nombre= @LOCALIDAD;
--telefonos
INSERT INTO Telefonos ( TipoTelefonoID, Telefono)
VALUES ( 1 , @Telefono);
SET @telefonoid = SCOPE_IDENTITY();
--gmail
INSERT INTO Gmail (Gmail)
VALUES (@Gmail);
SET @GmailID = SCOPE_IDENTITY();
--contacto
INSERT INTO contacto(Nombre,GmailID,idtelefono,tipo_documento,numero_documento,altura,calle,id_localidad)
VALUES (@Nombre,@GmailID,@telefonoid,@tipo_documento,@num_documento,@altura,@calle,@idloclidad);
SET @idcontacto = SCOPE_IDENTITY();
insert into cliente (fecha_nacimiento,idcontacto,bloqueado)
values (@fecha_nacimiento,@idcontacto,0)
GO

CREATE OR ALTER PROC speditar_cliente
@localidad nvarchar(20),
@nombre varchar(50),
@fecha_nacimiento date,
@tipo_documento varchar(20),
@num_documento varchar(11),
@altura int,
@calle varchar(100),
@telefono varchar(10),
@gmail varchar(50)
AS
declare @idcontacto int, @idtelefono int,@gmailID int,@idlocalidad int;
select @idcontacto = idcontacto from contacto where numero_documento=@num_documento
select @idtelefono= idtelefono from contacto where idcontacto=@idcontacto
select @gmailID= GmailID  from contacto where idcontacto=@idcontacto
SELECT  @idlocalidad = Id_localidad from localidades where Nombre= @localidad;
update Gmail set
gmail=@gmail
where GmailID =@gmailid
update Telefonos set
telefono=@telefono
where idtelefono=@idtelefono
update contacto set
nombre=@nombre,
tipo_documento = @tipo_documento,
numero_documento = @num_documento,
calle=@calle,
altura=@altura,
id_localidad=@idlocalidad
where idcontacto=@idcontacto
update cliente set 
fecha_nacimiento=@fecha_nacimiento
where idcontacto=@idcontacto
GO

CREATE OR ALTER PROC speliminar_cliente
@nroDocumento int
AS
-- [RECONSTRUIDO] baja lógica
declare @idcontacto int
select @idcontacto = idcontacto from contacto where numero_documento= @nroDocumento
update cliente set bloqueado=1
where idcontacto=@idcontacto
GO

CREATE OR ALTER PROC spbuscar_cliente_num_documento
@textobuscar varchar(50)
AS
select top 100 c.idcliente, co.Nombre,bloqueado, fecha_nacimiento, co.tipo_documento, co.numero_documento,
altura, calle,g.Gmail,t.Telefono
from cliente c
inner join  contacto co on c.idcontacto = co.idcontacto
inner join Gmail G on co.GmailID = G.GmailID
INNER JOIN Telefonos T ON co.idtelefono = T.idtelefono
where numero_documento like  '%'+ @textobuscar + '%'
GO

CREATE OR ALTER PROC spvalidarcliente
@numero_documento nvarchar(255)
AS
BEGIN
    -- [RECONSTRUIDO] la capa de lógica solo revisa si devuelve filas
    SELECT c.idcliente
    FROM cliente c
    INNER JOIN contacto co ON c.idcontacto = co.idcontacto
    WHERE co.numero_documento = @numero_documento AND c.bloqueado = 0;
END
GO

-- ---------- Proveedores ----------
CREATE OR ALTER PROC spmostrar_proveedor
AS
select top 100 idproveedor,c.nombre as proveedor,prov.sector_comercial,c.tipo_documento,c.numero_documento,c.id_localidad,c.calle,c.altura,prov.bloqueado,G.Gmail,T.Telefono
from proveedor prov
inner join contacto c on  prov.idcontacto =c.idcontacto
inner join Gmail G on c.GmailID = G.GmailID
INNER JOIN Telefonos T ON c.idtelefono = T.idtelefono
where prov.bloqueado=0
Order By nombre asc
GO

CREATE OR ALTER PROC spinsertar_proveedor
@nombre varchar(100),
@LOCALIDAD VARCHAR(100),
@sector_comercial varchar(50),
@tipo_documento varchar(20),
@num_documento varchar(11),
@calle varchar(100),
@altura int,
@telefono varchar(10),
@Gmail varchar(50),
@TipoTelefono NVARCHAR(50)
AS
declare  @TipoTelefonoID INT, @telefonoid int, @idcontacto int
DECLARE @idloclidad int, @GmailID INT
select @TipoTelefonoID = TipoTelefonoID FROM TipoTelefono where  Tipo = @TipoTelefono
SELECT @idloclidad = Id_localidad from localidades where Nombre= @LOCALIDAD
--telefonos
INSERT INTO Telefonos (TipoTelefonoID, Telefono)
VALUES (@TipoTelefonoID, @telefono);
SET @telefonoid = SCOPE_IDENTITY();
--gmail
INSERT INTO Gmail (Gmail)
VALUES (@Gmail);
SET @GmailID = SCOPE_IDENTITY();
--contacto
INSERT INTO contacto(nombre,GmailID,idtelefono,tipo_documento,numero_documento,calle,altura,id_localidad)
VALUES (@Nombre,@GmailID,@telefonoid,@tipo_documento,@num_documento,@calle,@altura,@idloclidad);
SET @idcontacto = SCOPE_IDENTITY();
--proveedor
insert into proveedor (sector_comercial,idcontacto,bloqueado)
values (@sector_comercial,@idcontacto,0)
GO

CREATE OR ALTER PROC speditar_proveedor
@localidad nvarchar(50),
@razon_social_old varchar(150),
@razon_social varchar(150),
@sector_comercial varchar(50),
@tipo_documento varchar(20),
@num_documento varchar(11),
@calle varchar(100),
@altura int,
@telefono varchar(10),
@gmail varchar(50)
AS
-- [RECONSTRUIDO] la versión del backup usaba el esquema viejo (Personas);
-- se rehizo con el esquema contacto, espejando speditar_cliente.
declare @idcontacto int, @idproveedor int, @idtelefono int,@gmailID int,@idlocalidad int;
select @idcontacto = idcontacto from contacto where nombre = @razon_social_old
select @idproveedor = idproveedor from proveedor where idcontacto=@idcontacto
select @idtelefono = idtelefono from contacto where idcontacto=@idcontacto
select @gmailID = GmailID from contacto where idcontacto=@idcontacto
SELECT @idlocalidad = Id_localidad from localidades where Nombre= @localidad;
update Telefonos set telefono=@telefono where idtelefono=@idtelefono
update Gmail set gmail=@gmail where GmailID=@gmailID
update contacto set
nombre=@razon_social,
tipo_documento=@tipo_documento,
numero_documento=@num_documento,
calle=@calle,
altura=@altura,
id_localidad=@idlocalidad
where idcontacto=@idcontacto
update proveedor set sector_comercial=@sector_comercial, bloqueado=0
where idproveedor=@idproveedor
GO

CREATE OR ALTER PROC speliminar_proveedor
@numeroDoc varchar(50)
AS
-- [RECONSTRUIDO] baja lógica
declare @idcontacto int
select @idcontacto = idcontacto from contacto where numero_documento= @numeroDoc
update proveedor set bloqueado=1
where idcontacto=@idcontacto
GO

CREATE OR ALTER PROC spbuscar_proveedor_num_documento
@textobuscar varchar(20)
AS
select top 100 idproveedor,co.nombre as proveedor,prov.sector_comercial,co.tipo_documento,co.numero_documento,co.id_localidad,co.calle,co.altura,prov.bloqueado,G.Gmail,T.Telefono
from proveedor prov
inner join contacto co on  prov.idcontacto =co.idcontacto
inner join Gmail G on co.GmailID = G.GmailID
INNER JOIN Telefonos T ON co.idtelefono = T.idtelefono
where numero_documento like  '%'+ @textobuscar + '%'
GO

CREATE OR ALTER PROC spbuscar_proveedor_razon_social
@textobuscar varchar(50)
AS
-- [RECONSTRUIDO] espejo de spbuscar_proveedor_num_documento, buscando por nombre
select top 100 idproveedor,co.nombre as proveedor,prov.sector_comercial,co.tipo_documento,co.numero_documento,co.id_localidad,co.calle,co.altura,prov.bloqueado,G.Gmail,T.Telefono
from proveedor prov
inner join contacto co on  prov.idcontacto =co.idcontacto
inner join Gmail G on co.GmailID = G.GmailID
INNER JOIN Telefonos T ON co.idtelefono = T.idtelefono
where co.nombre like  '%'+ @textobuscar + '%'
GO

CREATE OR ALTER PROC spvalidarprov
@numero_documento nvarchar(255)
AS
BEGIN
    -- [RECONSTRUIDO] la capa de lógica solo revisa si devuelve filas
    SELECT p.idproveedor
    FROM proveedor p
    INNER JOIN contacto co ON p.idcontacto = co.idcontacto
    WHERE co.numero_documento = @numero_documento AND p.bloqueado = 0;
END
GO

-- ---------- Artículos ----------
CREATE OR ALTER PROC spmostrar_articulo
AS
SELECT top 100 a.idarticulo,discontinuado as estado,a.codigo, a.nombre,a.precio_compra,a.precio_venta,a.stock,a.puntodereaprovisionamiento as aviso,a.descripcion,c.nombre AS Categoria,co.nombre as razon_social
FROM dbo.articulo a
INNER JOIN categoria c ON a.idcategoria = c.idcategoria 
inner join proveedor p on a.idproveedor = p.idproveedor
inner join contacto co on p.idcontacto = co.idcontacto
where a.discontinuado=0
order by a.idarticulo desc
GO

CREATE OR ALTER PROC spmostrar_articulo_combo
@idprov int
AS
SELECT articulo.idarticulo, articulo.nombre
FROM dbo.articulo
where articulo.idproveedor =@idprov and articulo.discontinuado=0
GO

CREATE OR ALTER PROC spinsertar_articulo
@nombre varchar(50),
@descripcion varchar(1024),
@idcategoria int,
@proveedor varchar(50),
@puntoreaprov int
AS
declare @idproveedor int,@idcontacto int;
select @idcontacto= idcontacto from contacto where nombre=@proveedor
select @idproveedor= idproveedor from proveedor where idcontacto=@idcontacto
insert into articulo (nombre,descripcion,idcategoria,idproveedor,puntodereaprovisionamiento)
values (@nombre,@descripcion, @idcategoria,@idproveedor,@puntoreaprov)
GO

CREATE OR ALTER PROC speditar_articulo
@idarticulo int,
@nombre varchar(50),
@descripcion varchar(1024),
@idcategoria int,
@proveedor varchar(50),
@puntoreaprov int
AS
declare @idproveedor int,@idcontacto int;
select @idcontacto = idcontacto FROM contacto where nombre= @proveedor
select @idproveedor= idproveedor from proveedor where idcontacto=@idcontacto
update articulo set nombre=@nombre,descripcion=@descripcion
,idcategoria=@idcategoria,idproveedor=@idproveedor,puntodereaprovisionamiento=@puntoreaprov
where idarticulo=@idarticulo
GO

CREATE OR ALTER PROC speliminar_articulo
@idarticulo int
AS
-- [RECONSTRUIDO] baja lógica
update articulo set discontinuado=1
where idarticulo=@idarticulo
GO

CREATE OR ALTER PROC spbuscar_articulo_nombre
@textobuscar varchar(50)
AS
SELECT top 100 a.idarticulo,discontinuado as estado, a.nombre,a.precio_compra,a.precio_venta,a.stock,a.puntodereaprovisionamiento as aviso,a.descripcion,c.nombre AS Categoria,co.nombre as razon_social
FROM dbo.articulo a
INNER JOIN categoria c ON a.idcategoria = c.idcategoria 
inner join proveedor p on a.idproveedor = p.idproveedor
inner join contacto co on p.idcontacto = co.idcontacto
where a.nombre like  '%'+ @textobuscar + '%'
order by a.idarticulo desc
GO

CREATE OR ALTER PROC spmostrar_precio
@idarticulo int
AS
BEGIN
    -- [RECONSTRUIDO] la lógica lee Rows[0][0] como precio
    SELECT precio_venta FROM articulo WHERE idarticulo = @idarticulo;
END
GO

CREATE OR ALTER PROC spaviso_stock
AS
BEGIN
    -- [RECONSTRUIDO] artículos en o por debajo del punto de reaprovisionamiento
    SELECT a.idarticulo, a.nombre, a.stock, a.puntodereaprovisionamiento AS punto_reaprovisionamiento,
           co.nombre AS proveedor
    FROM articulo a
    INNER JOIN proveedor p ON a.idproveedor = p.idproveedor
    INNER JOIN contacto co ON p.idcontacto = co.idcontacto
    WHERE a.discontinuado = 0 AND a.stock <= a.puntodereaprovisionamiento;
END
GO

CREATE OR ALTER PROC spmostrar_stock_articulo
@idarticulo int
AS
BEGIN
    -- [RECONSTRUIDO] versión con filtro por artículo del stock_articulo del backup
    SELECT a.codigo, a.nombre AS Nombre_Articulo, c.nombre AS Categoria,
           di.stock_inicial AS Cantidad_Ingreso, a.stock AS Cantidad_Stock,
           (di.stock_inicial - a.stock) AS Cantidad_Venta
    FROM articulo a
    INNER JOIN categoria c ON a.idcategoria = c.idcategoria
    INNER JOIN detalle_ingreso di ON a.idarticulo = di.idarticulo
    WHERE a.idarticulo = @idarticulo;
END
GO

-- ---------- Ingresos (compras) ----------
CREATE OR ALTER PROC spmostrar_ingreso
AS
select top 100 i.idingreso,U.Username as empleado,c.nombre as Proveedor,a.nombre as articulo,(i.total/i.cantidad)as precio_compra,i.total,i.fecha
from ingreso i
inner join articulo a on i.idarticulo= a.idarticulo
inner join proveedor p on i.idproveedor=p.idproveedor
inner join contacto c on p.idcontacto = c.idcontacto
inner join Users U on i.UserID=U.UserID
where i.anulado=0
GO

CREATE OR ALTER PROC spinsertar_ingreso
@UserID int,
@idproveedor int,
@fecha date,
@idarticulo int,
@precio_compra money,
@cantidad int,
@total money,
@fecha_produccion date = NULL,  -- la app llama con 7 parámetros; estos dos quedan opcionales
@fecha_vencimiento date = NULL
AS
declare @precio_venta money
set @precio_venta=@precio_compra*1.5
insert into ingreso (UserID,idproveedor,fecha,idarticulo,cantidad,total,fecha_produccion,fecha_vencimiento,anulado)
values (@UserID,@idproveedor,@fecha,@idarticulo,@cantidad,@total,@fecha_produccion,@fecha_vencimiento,0)
-- [RECONSTRUIDO] actualización de stock y precios (fragmento recuperado del backup)
IF EXISTS (SELECT 1 FROM articulo WHERE idarticulo=@idarticulo AND precio_venta > 0)
BEGIN
    UPDATE articulo
    SET stock = stock + @cantidad , precio_compra = @precio_compra
    WHERE idarticulo = @idarticulo
END
ELSE
BEGIN
    UPDATE articulo
    SET stock = stock + @cantidad , precio_compra = @precio_compra , precio_venta = @precio_venta
    WHERE idarticulo = @idarticulo
END
GO

CREATE OR ALTER PROC speliminar_ingreso
@idingreso int
AS
update  ingreso set anulado=1
where idingreso=@idingreso
GO

CREATE OR ALTER PROC spbuscar_ingreso_fecha
@fechaInicio date,
@fechaFin date
AS
select top 100 U.Username as empleado,co.nombre as Proveedor,a.nombre as articulo,i.cantidad,a.precio_compra,total,i.fecha
from ingreso i
inner join articulo a on i.idarticulo= a.idarticulo
inner join proveedor p on i.idproveedor=p.idproveedor
inner join contacto co on p.idcontacto=co.idcontacto
inner join Users U on i.UserID=U.UserID
where i.fecha>=@fechaInicio and i.fecha<=@fechaFin
GO

CREATE OR ALTER PROC spconfirmar_ingreso
@tipo_comprobante varchar(20),
@numero int,
@idingreso int,
@fecha date,
@fechaproduccion date,
@fechavencimiento date
AS
BEGIN
    -- [RECONSTRUIDO] registra el comprobante del ingreso y completa fechas
    INSERT INTO ingreso_realizado (idingreso, fecha, tipo_compobante, numero_comprobante)
    VALUES (@idingreso, @fecha, @tipo_comprobante, @numero);

    UPDATE ingreso
    SET fecha_produccion = @fechaproduccion, fecha_vencimiento = @fechavencimiento
    WHERE idingreso = @idingreso;
END
GO

CREATE OR ALTER PROC spmostrar_ingreso_confirmado
AS
BEGIN
    -- [RECONSTRUIDO] espejo sin filtro de spbuscar_ingreso_confirmado_fecha
    select top 100 U.Username as empleado, co.nombre as Proveedor,a.nombre as articulo,i.cantidad,a.precio_compra,i.total,ir.fecha,ir.tipo_compobante as tipo,ir.numero_comprobante
    from ingreso i
    inner join articulo a on i.idarticulo= a.idarticulo
    inner join proveedor p on i.idproveedor=p.idproveedor
    inner join contacto co on p.idcontacto=co.idcontacto
    inner join Users U on i.UserID=U.UserID
    inner join ingreso_realizado ir on i.idingreso=ir.idingreso
END
GO

CREATE OR ALTER PROC spbuscar_ingreso_confirmado_fecha
@fechaInicio date,
@fechaFin date
AS
select top 100 U.Username as empleado, co.nombre as Proveedor,a.nombre as articulo,i.cantidad,a.precio_compra,i.total,ir.fecha,ir.tipo_compobante as tipo,ir.numero_comprobante
from ingreso i
inner join articulo a on i.idarticulo= a.idarticulo
inner join proveedor p on i.idproveedor=p.idproveedor
inner join contacto co on p.idcontacto=co.idcontacto
inner join Users U on i.UserID=U.UserID
inner join ingreso_realizado ir on i.idingreso=ir.idingreso
where i.fecha>=@fechaInicio and i.fecha<=@fechaFin
GO

-- ---------- Ventas ----------
CREATE OR ALTER PROC spmostrar_venta
AS
select top 100 v.idventa, U.username as empleado, co.nombre as cliente,a.nombre as articulo,cantidad,a.precio_venta,total,v.fecha,v.tipo_comprobante,numero_comprobante
from venta v
inner join articulo a on v.idarticulo=a.idarticulo
inner join cliente c on v.idcliente=c.idcliente
inner join contacto co on c.idcontacto = co.idcontacto
inner join Users U on v.UserID=U.UserID
where v.anulado=0
order by v.numero_comprobante
GO

CREATE OR ALTER PROC spinsertar_venta
@idcliente int,
@UserID int,
@fecha date,
@tipo_comprobante varchar(20),
@numero int,
@idarticulo int,
@cantidad int
AS
declare @precio_venta money,@total money
select @precio_venta = precio_venta from articulo where @idarticulo=idarticulo
set @total = @precio_venta * @cantidad
insert into venta (idcliente,UserID,fecha,tipo_comprobante,numero_comprobante,idarticulo,cantidad,total)
values (@idcliente,@UserID,@fecha,@tipo_comprobante,@numero,@idarticulo,@cantidad,@total)
 UPDATE articulo 
 SET stock = stock - @cantidad 
 where idarticulo=@idarticulo
GO

CREATE OR ALTER PROC speliminar_venta
@idventa int
AS
update  venta set anulado=1
where idventa=@idventa
GO

CREATE OR ALTER PROC spbuscar_venta_fecha
@fechaInicio date,
@fechaFin date
AS
select top 100 v.idventa, U.username as empleado, co.nombre as cliente,a.nombre as articulo,cantidad,a.precio_venta,total,v.fecha,v.tipo_comprobante,numero_comprobante
from venta v
inner join articulo a on v.idarticulo=a.idarticulo
inner join cliente c on v.idcliente=c.idcliente
inner join contacto co on c.idcontacto = co.idcontacto
inner join Users U on v.UserID=U.UserID
where v.fecha>=@fechaInicio and v.fecha<=@fechaFin
order by v.numero_comprobante desc
GO

CREATE OR ALTER PROC spreporte_factura
@idventa int
AS
-- [ADAPTADO] el original leía c.num_documento de cliente; con el esquema
-- actual el documento vive en contacto.
select dv.precio_venta,dv.cantidad,v.idventa,v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.igv,
a.nombre, c.idcliente as Cliente,co.numero_documento as num_documento, U.Username as Users,
(dv.cantidad * dv.precio_venta) as Total_Parcial
from detalle_venta dv 
inner join detalle_ingreso di on dv.iddetalle_ingreso = di.iddetalle_ingreso
inner join articulo a on a.idarticulo = di.idarticulo
inner join venta v on v.idventa = dv.idventa
inner join cliente c on v.idcliente = c.idcliente
inner join contacto co on c.idcontacto = co.idcontacto
inner join Users U on U.UserID = v.UserID
where v.idventa=@idventa
GO

-- ---------- Trabajador (módulo legado) ----------
CREATE OR ALTER PROC spinsertar_trabajador
@idtrabajador int output,
@nombre varchar(20), @apellidos varchar(40), @sexo varchar(1),
@fecha_nacimiento date, @num_documento varchar(8), @direccion varchar(100),
@telefono varchar(10), @email varchar(50), @acceso varchar(20),
@usuario varchar(20), @password varchar(20)
AS
insert into trabajador (nombre,apellidos,sexo,fecha_nac,
num_documento,direccion,telefono,email,acceso,usuario,password)
values (@nombre,@apellidos,@sexo,@fecha_nacimiento,
@num_documento,@direccion,@telefono,@email,@acceso,@usuario,@password)
set @idtrabajador = SCOPE_IDENTITY()
GO

CREATE OR ALTER PROC speditar_trabajador
@idtrabajador int,
@nombre varchar(20), @apellidos varchar(40), @sexo varchar(1),
@fecha_nacimiento date, @num_documento varchar(8), @direccion varchar(100),
@telefono varchar(10), @email varchar(50), @acceso varchar(20),
@usuario varchar(20), @password varchar(20)
AS
update trabajador set nombre=@nombre,apellidos=@apellidos,
sexo=@sexo,fecha_nac=@fecha_nacimiento,num_documento=@num_documento,
direccion=@direccion,telefono=@telefono,email=@email,
acceso=@acceso,usuario=@usuario,password=@password
where idtrabajador=@idtrabajador
GO

CREATE OR ALTER PROC speliminar_trabajador
@idtrabajador int
AS
delete from trabajador
where idtrabajador=@idtrabajador
GO

-- ---------- Usuarios y seguridad ----------
-- La app guarda como Password: SHA256(contraseña)+SHA256(usuario) en hex.

CREATE OR ALTER PROC spConsultarLogueo
    @Username NVARCHAR(50),
    @Password NVARCHAR(max)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Users WHERE Username = @Username AND Password = @Password)
    BEGIN
        -- [RECONSTRUIDO el cierre] joins a Gmail/Telefonos vía Personas
        SELECT U.Nuevo,U.bloqueado,U.UserID ,P.Permiso, FI.Fecha , FF.Fecha, I.Intentos ,G.Gmail,T.idtelefono
        FROM Users U
        INNER JOIN UsuariosPermisos UP ON U.UserID = UP.UserID
        INNER JOIN Permisos P ON UP.PermisoID = P.PermisoID
        INNER JOIN FechaInicio FI ON U.UserID = FI.UserID
        INNER JOIN FechaFin FF ON U.UserID = FF.UserID
        INNER JOIN Intentos I ON U.UserID = I.UserID
        INNER JOIN Personas PE ON U.PersonaID = PE.PersonaID
        INNER JOIN Gmail G ON PE.GmailID = G.GmailID
        INNER JOIN Telefonos T ON PE.idtelefono = T.idtelefono
        WHERE U.Username = @Username;
    END
END
GO

CREATE OR ALTER PROC spObtenerDatosU
    @Username NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    -- [RECONSTRUIDO el cierre]
    SELECT P.Nombre,U.UserID, U.Password ,U.bloqueado, Permiso AS Permisos, FF.Fecha AS FechaFin,G.Gmail
    FROM Users U
    INNER JOIN Personas P ON U.PersonaID = P.PersonaID
    INNER JOIN UsuariosPermisos UP ON U.UserID = UP.UserID
    INNER JOIN Permisos PR ON UP.PermisoID = PR.PermisoID
    INNER JOIN FechaFin FF ON U.UserID = FF.UserID
    INNER JOIN Gmail G ON P.GmailID = G.GmailID
    WHERE U.Username = @Username;
END
GO

CREATE OR ALTER PROC spAgregarUsuario
    @Username NVARCHAR(50),
    @Password NVARCHAR(max),
    @Nombre NVARCHAR(50),
    @Gmail NVARCHAR(50),
    @NumeroTelefono NVARCHAR(50),
    @TipoTelefono NVARCHAR(50),
    @FechaInicio DATETIME,
    @FechaFin DATETIME,
    @Permiso NVARCHAR(50),
    @localidad NVARCHAR(50)
AS
BEGIN
    -- [RECONSTRUIDO] alta completa: teléfono → gmail → persona → user → permisos → fechas → intentos
    SET NOCOUNT ON;
    DECLARE @TipoTelefonoID INT, @idtelefono INT, @GmailID INT,
            @PersonaID INT, @UserID INT, @PermisoID INT, @idlocalidad INT;

    SELECT @TipoTelefonoID = TipoTelefonoID FROM TipoTelefono WHERE Tipo = @TipoTelefono;
    SELECT @idlocalidad = Id_localidad FROM localidades WHERE Nombre = @localidad;
    SELECT @PermisoID = PermisoID FROM Permisos WHERE Permiso = @Permiso;

    INSERT INTO Telefonos (TipoTelefonoID, Telefono) VALUES (@TipoTelefonoID, @NumeroTelefono);
    SET @idtelefono = SCOPE_IDENTITY();

    INSERT INTO Gmail (Gmail) VALUES (@Gmail);
    SET @GmailID = SCOPE_IDENTITY();

    INSERT INTO Personas (Nombre, GmailID, idtelefono, id_localidad)
    VALUES (@Nombre, @GmailID, @idtelefono, @idlocalidad);
    SET @PersonaID = SCOPE_IDENTITY();

    INSERT INTO Users (Username, Password, PersonaID, Nuevo, bloqueado)
    VALUES (@Username, @Password, @PersonaID, 1, 0);
    SET @UserID = SCOPE_IDENTITY();

    INSERT INTO UsuariosPermisos (UserID, PermisoID) VALUES (@UserID, @PermisoID);
    INSERT INTO FechaInicio (UserID, Fecha) VALUES (@UserID, @FechaInicio);
    INSERT INTO FechaFin (UserID, Fecha) VALUES (@UserID, @FechaFin);
    INSERT INTO Intentos (UserID, Intentos) VALUES (@UserID, 0);
    INSERT INTO HistorialContrasenas (UserID, Password) VALUES (@UserID, @Password);
END
GO

CREATE OR ALTER PROC spObtenerConfiguracionSistema
AS
BEGIN
    -- [RECONSTRUIDO] la app lee 5 FILAS en este orden:
    -- Minchar, MayusyMin, Especiales, Validacion, RepetirC
    SELECT t.valor
    FROM (SELECT Minchar, MayusyMin, Especiales, Validacion, RepetirC FROM ConfiguracionSistema) s
    CROSS APPLY (VALUES (1, s.Minchar), (2, s.MayusyMin), (3, s.Especiales),
                        (4, s.Validacion), (5, s.RepetirC)) t(orden, valor)
    ORDER BY t.orden;
END
GO

CREATE OR ALTER PROC spActualizarConfiguracionSistema
@Minchar bit,
@MayusyMin bit,
@Especiales bit,
@Validacion bit,
@RepetirC bit
AS
BEGIN
    -- [RECONSTRUIDO] la tabla tiene una sola fila
    UPDATE ConfiguracionSistema
    SET Minchar=@Minchar, MayusyMin=@MayusyMin, Especiales=@Especiales,
        Validacion=@Validacion, RepetirC=@RepetirC;
END
GO

CREATE OR ALTER PROC spActualizarBloqueoUsuario
@bloqueado bit,
@nombre nvarchar(50)
AS
BEGIN
    -- [RECONSTRUIDO] al desbloquear se reinician los intentos
    UPDATE Users SET bloqueado=@bloqueado WHERE Username=@nombre;
    IF @bloqueado = 0
        UPDATE I SET Intentos = 0
        FROM Intentos I INNER JOIN Users U ON I.UserID = U.UserID
        WHERE U.Username = @nombre;
END
GO

CREATE OR ALTER PROC spActualizarContraseñas
@nombre nvarchar(50),
@Password nvarchar(max)
AS
BEGIN
    -- [RECONSTRUIDO] cambia la contraseña y la registra en el historial
    DECLARE @UserID INT;
    SELECT @UserID = UserID FROM Users WHERE Username=@nombre;
    UPDATE Users SET Password=@Password, Nuevo=0 WHERE UserID=@UserID;
    INSERT INTO HistorialContrasenas (UserID, Password) VALUES (@UserID, @Password);
END
GO

CREATE OR ALTER PROC spConsultarContraseñasRepetidas
@nombre nvarchar(50),
@Password nvarchar(max)
AS
BEGIN
    -- [RECONSTRUIDO] devuelve filas si la contraseña ya fue usada
    SELECT H.Password
    FROM HistorialContrasenas H
    INNER JOIN Users U ON H.UserID = U.UserID
    WHERE U.Username=@nombre AND H.Password=@Password;
END
GO

CREATE OR ALTER PROC spActualizarPreguntaSeguridad
@nombre nvarchar(50),
@pregunta nvarchar(50),
@respuesta nvarchar(50)
AS
BEGIN
    -- [RECONSTRUIDO] reemplaza la pregunta/respuesta del usuario
    DECLARE @UserID INT;
    SELECT @UserID = UserID FROM Users WHERE Username=@nombre;
    DELETE FROM RespuestaSeguridad WHERE UserID=@UserID;
    INSERT INTO RespuestaSeguridad (UserID, Pregunta, Respuesta)
    VALUES (@UserID, @pregunta, @respuesta);
END
GO

CREATE OR ALTER PROC spObtenerPreguntaSeg
@username nvarchar(50)
AS
BEGIN
    -- [RECONSTRUIDO]
    SELECT R.Pregunta
    FROM RespuestaSeguridad R
    INNER JOIN Users U ON R.UserID = U.UserID
    WHERE U.Username=@username;
END
GO

CREATE OR ALTER PROC spConsultarPreguntasSeguridad
@nombre nvarchar(50),
@pregunta nvarchar(50),
@respuesta nvarchar(50)
AS
BEGIN
    -- [RECONSTRUIDO] devuelve filas si la respuesta es correcta
    SELECT R.UserID
    FROM RespuestaSeguridad R
    INNER JOIN Users U ON R.UserID = U.UserID
    WHERE U.Username=@nombre AND R.Pregunta=@pregunta AND R.Respuesta=@respuesta;
END
GO

CREATE OR ALTER PROC spconsultarUsuario
@Username nvarchar(255)
AS
BEGIN
    -- [RECONSTRUIDO] chequeo de existencia (la lógica mira Rows.Count)
    SELECT Username FROM Users WHERE Username=@Username;
END
GO

CREATE OR ALTER PROC spobtenerUsuarios
AS
BEGIN
    -- [RECONSTRUIDO] grilla de administración de usuarios
    SELECT U.UserID, U.Username, P.Nombre, PR.Permiso, U.bloqueado, FF.Fecha AS FechaFin
    FROM Users U
    LEFT JOIN Personas P ON U.PersonaID = P.PersonaID
    INNER JOIN UsuariosPermisos UP ON U.UserID = UP.UserID
    INNER JOIN Permisos PR ON UP.PermisoID = PR.PermisoID
    INNER JOIN FechaFin FF ON U.UserID = FF.UserID;
END
GO

CREATE OR ALTER PROC spBorrarInfoPersonal
    @UsesrID INT   -- [sic] nombre del parámetro tal como lo envía la app
AS
BEGIN
    -- [RECONSTRUIDO] elimina datos sensibles del usuario
    DELETE FROM RespuestaSeguridad WHERE UserID=@UsesrID;
    UPDATE G SET Gmail=''
    FROM Gmail G
    INNER JOIN Personas P ON G.GmailID = P.GmailID
    INNER JOIN Users U ON U.PersonaID = P.PersonaID
    WHERE U.UserID=@UsesrID;
    UPDATE T SET Telefono=''
    FROM Telefonos T
    INNER JOIN Personas P ON T.idtelefono = P.idtelefono
    INNER JOIN Users U ON U.PersonaID = P.PersonaID
    WHERE U.UserID=@UsesrID;
END
GO

CREATE OR ALTER PROC spActualizarUser
@UserID INT,
@Username NVARCHAR(50),
@Permiso NVARCHAR(50),
@FechaFin DATETIME
AS
BEGIN
    -- [RECONSTRUIDO]
    UPDATE Users SET Username=@Username WHERE UserID=@UserID;
    UPDATE UsuariosPermisos
    SET PermisoID = (SELECT PermisoID FROM Permisos WHERE Permiso=@Permiso)
    WHERE UserID=@UserID;
    UPDATE FechaFin SET Fecha=@FechaFin WHERE UserID=@UserID;
END
GO

CREATE OR ALTER PROC speditar_users
@UserID INT,
@bloqueado BIT,
@Username NVARCHAR(50),
@Permiso NVARCHAR(50),
@FechaFin DATETIME
AS
BEGIN
    -- [RECONSTRUIDO el cuerpo]
    UPDATE Users SET Username=@Username, bloqueado=@bloqueado WHERE UserID=@UserID;
    UPDATE UsuariosPermisos
    SET PermisoID = (SELECT PermisoID FROM Permisos WHERE Permiso=@Permiso)
    WHERE UserID=@UserID;
    UPDATE FechaFin SET Fecha=@FechaFin WHERE UserID=@UserID;
END
GO

-- ==================== DATOS INICIALES ====================

INSERT INTO localidades (Nombre) VALUES
('Lanús'),('Avellaneda'),('Lomas de Zamora'),('Banfield'),('CABA');
GO
INSERT INTO TipoTelefono (Tipo) VALUES ('Celular'),('Fijo');
GO
-- Permisos que espera frmAplicacion.cs: admin (todo), empleado1 (compras), empleado2 (ventas)
INSERT INTO Permisos (Permiso) VALUES ('admin'),('empleado1'),('empleado2');
GO
-- Política de contraseñas: todo desactivado para arrancar
INSERT INTO ConfiguracionSistema (Minchar, MayusyMin, Especiales, Validacion, RepetirC)
VALUES (0,0,0,0,0);
GO
INSERT INTO PreguntasSeguridad (Pregunta) VALUES
('¿Nombre de tu primera mascota?'),
('¿Ciudad donde naciste?'),
('¿Nombre de tu escuela primaria?');
GO

-- ---------- Usuarios de prueba (contraseña "1234") ----------
-- Password = SHA256("1234") + SHA256(username), en hexadecimal minúscula.
DECLARE @g INT, @t INT, @p INT, @u INT;

-- admin / 1234
INSERT INTO Gmail (Gmail) VALUES ('admin@ejemplo.com'); SET @g = SCOPE_IDENTITY();
INSERT INTO Telefonos (TipoTelefonoID, Telefono) VALUES (1,'1100000000'); SET @t = SCOPE_IDENTITY();
INSERT INTO Personas (Nombre, GmailID, idtelefono, id_localidad) VALUES ('Administrador', @g, @t, 1); SET @p = SCOPE_IDENTITY();
INSERT INTO Users (Username, Password, PersonaID, Nuevo, bloqueado)
VALUES ('admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f48c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', @p, 0, 0);
SET @u = SCOPE_IDENTITY();
INSERT INTO UsuariosPermisos (UserID, PermisoID) VALUES (@u, (SELECT PermisoID FROM Permisos WHERE Permiso='admin'));
INSERT INTO FechaInicio (UserID, Fecha) VALUES (@u, GETDATE());
INSERT INTO FechaFin (UserID, Fecha) VALUES (@u, '2030-01-01');
INSERT INTO Intentos (UserID, Intentos) VALUES (@u, 0);

-- empleado / 1234 (rol empleado1: compras)
INSERT INTO Gmail (Gmail) VALUES ('empleado@ejemplo.com'); SET @g = SCOPE_IDENTITY();
INSERT INTO Telefonos (TipoTelefonoID, Telefono) VALUES (1,'1100000001'); SET @t = SCOPE_IDENTITY();
INSERT INTO Personas (Nombre, GmailID, idtelefono, id_localidad) VALUES ('Empleado Demo', @g, @t, 1); SET @p = SCOPE_IDENTITY();
INSERT INTO Users (Username, Password, PersonaID, Nuevo, bloqueado)
VALUES ('empleado', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f40baff97ff722b0be472c1ff5a1edabf7cefb089d0575794975c3007989327efa', @p, 0, 0);
SET @u = SCOPE_IDENTITY();
INSERT INTO UsuariosPermisos (UserID, PermisoID) VALUES (@u, (SELECT PermisoID FROM Permisos WHERE Permiso='empleado1'));
INSERT INTO FechaInicio (UserID, Fecha) VALUES (@u, GETDATE());
INSERT INTO FechaFin (UserID, Fecha) VALUES (@u, '2030-01-01');
INSERT INTO Intentos (UserID, Intentos) VALUES (@u, 0);
GO

-- ---------- Datos de demostración ----------
DECLARE @g INT, @t INT, @c INT;

INSERT INTO categoria (nombre, descripcion) VALUES ('Bebidas','Gaseosas, aguas y jugos');

-- proveedor demo
INSERT INTO Gmail (Gmail) VALUES ('ventas@distribuidoranorte.com'); SET @g = SCOPE_IDENTITY();
INSERT INTO Telefonos (TipoTelefonoID, Telefono) VALUES (2,'42000000'); SET @t = SCOPE_IDENTITY();
INSERT INTO contacto (Nombre, GmailID, idtelefono, tipo_documento, numero_documento, calle, altura, id_localidad)
VALUES ('Distribuidora Norte', @g, @t, 'CUIT', '30111111112', 'Av. Mitre', 1500, 2);
SET @c = SCOPE_IDENTITY();
INSERT INTO proveedor (sector_comercial, idcontacto, bloqueado) VALUES ('Bebidas', @c, 0);

-- cliente demo
INSERT INTO Gmail (Gmail) VALUES ('cliente@ejemplo.com'); SET @g = SCOPE_IDENTITY();
INSERT INTO Telefonos (TipoTelefonoID, Telefono) VALUES (1,'1155555555'); SET @t = SCOPE_IDENTITY();
INSERT INTO contacto (Nombre, GmailID, idtelefono, tipo_documento, numero_documento, calle, altura, id_localidad)
VALUES ('Juan Pérez', @g, @t, 'DNI', '30123456', 'French', 200, 1);
SET @c = SCOPE_IDENTITY();
INSERT INTO cliente (fecha_nacimiento, idcontacto, bloqueado) VALUES ('1990-05-10', @c, 0);

-- artículos demo
INSERT INTO articulo (codigo, nombre, descripcion, idcategoria, idproveedor, puntodereaprovisionamiento, stock, precio_compra, precio_venta, discontinuado)
VALUES ('A001', 'Agua mineral 1.5L', 'Pack individual', 1, 1, 10, 50, 500, 750, 0),
       ('A002', 'Gaseosa cola 2.25L', 'Retornable', 1, 1, 12, 30, 1200, 1800, 0);
GO

PRINT 'dbventas creada correctamente. Usuarios: admin/1234 (admin), empleado/1234 (compras).';
GO
