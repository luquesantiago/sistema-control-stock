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
2. Ejecutar `dbventas.sql` en SQL Server (SSMS) para crear la base con datos de prueba, y ajustar la cadena de conexión `dbventas` en `Login/App.config`
3. Compilar y ejecutar el proyecto `Login`

> **Usuarios de prueba** (contraseña `1234`): `admin` (acceso completo) y `empleado` (módulo de compras).
>
> El script `dbventas.sql` fue reconstruido a partir del backup original del proyecto: los cuerpos de los procedimientos provienen del `Sistema.bak` histórico y las tablas se derivaron de sus consultas. Los procedimientos que estaban truncados en el backup están marcados como `[RECONSTRUIDO]`.
