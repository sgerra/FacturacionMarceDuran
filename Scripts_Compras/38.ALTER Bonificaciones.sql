/*
   jueves, 11 de diciembre de 201414:11:13
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
CREATE TABLE dbo.Tmp_Bonificaciones
	(
	bon_idbon int NOT NULL,
	bon_fecha smalldatetime NULL,
	bon_nro int NULL,
	bon_nrobon nvarchar(50) NULL,
	bon_nroprove int NULL,
	bon_concepto nvarchar(100) NULL,
	bon_monto float(53) NULL,
	bon_comprobante nvarchar(50) NULL,
	bon_usada bit NOT NULL,
	bon_nropago int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Bonificaciones SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT * FROM dbo.Bonificaciones)
	 EXEC('INSERT INTO dbo.Tmp_Bonificaciones (bon_idbon, bon_fecha, bon_nro, bon_nrobon, bon_nroprove, bon_concepto, bon_monto, bon_comprobante, bon_usada)
		SELECT bon_idbon, bon_fecha, bon_nro, bon_nrobon, bon_nroprove, bon_concepto, bon_monto, bon_comprobante, bon_usada FROM dbo.Bonificaciones WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Bonificaciones
GO
EXECUTE sp_rename N'dbo.Tmp_Bonificaciones', N'Bonificaciones', 'OBJECT' 
GO
COMMIT
