/*
   miércoles, 21 de enero de 201515:50:02
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
CREATE TABLE dbo.Tmp_Clientes
	(
	cli_idcliente int NOT NULL IDENTITY (1, 1),
	cli_nombrefantasia varchar(200) NULL,
	cli_razonsocial varchar(200) NULL,
	cli_apynom varchar(200) NULL,
	cli_cativa int NULL,
	cli_cuit varchar(50) NULL,
	cli_domicilio varchar(200) NULL,
	cli_idpcia int NULL,
	cli_idciudad int NULL,
	cli_telefono varchar(200) NULL,
	cli_telCel varchar(50) NULL,
	cli_email varchar(100) NULL,
	cli_obs varchar(500) NULL,
	cli_listaprecios int NULL,
	cli_idDeposito int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Clientes SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Clientes ON
GO
IF EXISTS(SELECT * FROM dbo.Clientes)
	 EXEC('INSERT INTO dbo.Tmp_Clientes (cli_idcliente, cli_nombrefantasia, cli_razonsocial, cli_apynom, cli_cativa, cli_cuit, cli_domicilio, cli_idpcia, cli_idciudad, cli_telefono, cli_email, cli_obs, cli_listaprecios, cli_idDeposito)
		SELECT cli_idcliente, cli_nombrefantasia, cli_razonsocial, cli_apynom, cli_cativa, cli_cuit, cli_domicilio, cli_idpcia, cli_idciudad, cli_telefono, cli_email, cli_obs, cli_listaprecios, cli_idDeposito FROM dbo.Clientes WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Clientes OFF
GO
DROP TABLE dbo.Clientes
GO
EXECUTE sp_rename N'dbo.Tmp_Clientes', N'Clientes', 'OBJECT' 
GO
ALTER TABLE dbo.Clientes ADD CONSTRAINT
	PK_Clientes PRIMARY KEY CLUSTERED 
	(
	cli_idcliente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
