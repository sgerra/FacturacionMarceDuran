/*
   jueves, 26 de febrero de 20159:59:03
   Usuario: sa
   Servidor: NBK-DIEGO\SQLEXPRESS
   Base de datos: Facturacion
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
EXECUTE sp_rename N'dbo.Compras_Detalles.porcImpInt', N'Tmp_porcUtil', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Compras_Detalles.montoImpInt', N'Tmp_montoUtil_1', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Compras_Detalles.Tmp_porcUtil', N'porcUtil', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Compras_Detalles.Tmp_montoUtil_1', N'montoUtil', 'COLUMN' 
GO
ALTER TABLE dbo.Compras_Detalles SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
