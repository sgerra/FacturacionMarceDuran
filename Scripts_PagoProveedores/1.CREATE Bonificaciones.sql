/*
   martes, 2 de diciembre de 201411:24:53
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
ALTER TABLE dbo.Bonificaciones
	DROP COLUMN bon_soc_id
GO
ALTER TABLE dbo.Bonificaciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
