/*
   viernes, 30 de enero de 201513:36:33
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
CREATE TABLE dbo.Tmp_Usuarios
	(
	usu_id int NOT NULL IDENTITY (1, 1),
	usu_identi varchar(50) NULL,
	usu_apeynom varchar(50) NULL,
	usu_clave varchar(10) NULL,
	usu_prf_id int NULL,
	usu_entrada char(1) NULL,
	usu_auditor char(1) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Usuarios SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Usuarios ON
GO
IF EXISTS(SELECT * FROM dbo.Usuarios)
	 EXEC('INSERT INTO dbo.Tmp_Usuarios (usu_id, usu_identi, usu_apeynom, usu_clave, usu_prf_id, usu_entrada, usu_auditor)
		SELECT usu_id, usu_identi, usu_apeynom, usu_clave, usu_prf_id, usu_entrada, usu_auditor FROM dbo.Usuarios WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Usuarios OFF
GO
DROP TABLE dbo.Usuarios
GO
EXECUTE sp_rename N'dbo.Tmp_Usuarios', N'Usuarios', 'OBJECT' 
GO
ALTER TABLE dbo.Usuarios ADD CONSTRAINT
	PK_Usuarios PRIMARY KEY CLUSTERED 
	(
	usu_id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
