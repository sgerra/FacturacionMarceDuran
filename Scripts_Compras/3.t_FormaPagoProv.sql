/*
   miércoles, 22 de octubre de 201402:52:08 p.m.
   Usuario: sa
   Servidor: SISTEMAS01\SQLEXPRESS
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
CREATE TABLE dbo.Tmp_t_FormaPagoProv
	(
	idformaPago int NOT NULL,
	descri varchar(100) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_t_FormaPagoProv SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT * FROM dbo.t_FormaPagoProv)
	 EXEC('INSERT INTO dbo.Tmp_t_FormaPagoProv (idformaPago, descri)
		SELECT idformaPago, descri FROM dbo.t_FormaPagoProv WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.t_FormaPagoProv
GO
EXECUTE sp_rename N'dbo.Tmp_t_FormaPagoProv', N't_FormaPagoProv', 'OBJECT' 
GO
ALTER TABLE dbo.t_FormaPagoProv ADD CONSTRAINT
	PK_t_FormaPagoProv PRIMARY KEY CLUSTERED 
	(
	idformaPago
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
