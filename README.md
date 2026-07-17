# Sistema de control de stock

Sistema de escritorio para gestión de stock, compras y ventas de un comercio, desarrollado en **C# (WinForms)** con **SQL Server** como proyecto final del secundario técnico.

## Funcionalidades

- **Login** con roles y recuperación de contraseña por preguntas de seguridad
- **Compras:** artículos, categorías, proveedores, órdenes de compra e ingresos de mercadería
- **Ventas:** clientes, ventas y egresos, con carrito
- **Administración:** gestión de usuarios y configuración del sistema

## Arquitectura en capas

| Proyecto | Capa |
|----------|------|
| `Login` (capaVista) | Presentación — formularios WinForms |
| `logica` | Lógica de negocio |
| `datos` | Acceso a datos — ADO.NET con **procedimientos almacenados** por entidad |
| `comun` | Entidades y caché compartida |
| `servicios` | Utilidades de UI |

El acceso a la base se hace exclusivamente vía procedimientos almacenados (artículos, categorías, clientes, proveedores, ventas, usuarios, etc.).

## Tecnologías

C# · .NET Framework 4.7.2 · WinForms · SQL Server · ADO.NET

## Ejecutar

1. Abrir `Login.sln` en Visual Studio
2. Crear la base `dbventas` en SQL Server y ajustar la cadena de conexión en `datos/conn.cs`
3. Compilar y ejecutar el proyecto `Login`

> El script de creación de la base de datos está pendiente de publicación.
