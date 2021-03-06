/*
   jueves, 20 de noviembre de 201410:16:52 a.m.
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
CREATE TABLE dbo.Tmp_Compras
	(
	idCompra int NOT NULL IDENTITY (1, 1),
	NroFactura varchar(50) NULL,
	Fecha datetime NULL,
	FechaEntrega datetime NULL,
	idcondPago int NULL,
	idTipoFact int NULL,
	idEstado int NULL,
	idProveedor int NULL,
	observaciones varchar(1000) NULL,
	PbaseTot decimal(18, 2) NULL,
	IvaTot decimal(18, 2) NULL,
	ImpIntTot decimal(18, 2) NULL,
	percepIvaTot decimal(18, 2) NULL,
	percepIBTot decimal(18, 2) NULL,
	descuentoTot decimal(18, 2) NULL,
	total decimal(18, 2) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Compras SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Compras ON
GO
IF EXISTS(SELECT * FROM dbo.Compras)
	 EXEC('INSERT INTO dbo.Tmp_Compras (idCompra, NroFactura, Fecha, idcondPago, idTipoFact, idEstado, idProveedor, observaciones, PbaseTot, IvaTot, ImpIntTot, percepIvaTot, percepIBTot, descuentoTot, total)
		SELECT idCompra, NroFactura, Fecha, idcondPago, idTipoFact, idEstado, idProveedor, observaciones, PbaseTot, IvaTot, ImpIntTot, percepIvaTot, percepIBTot, descuentoTot, total FROM dbo.Compras WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Compras OFF
GO
DROP TABLE dbo.Compras
GO
EXECUTE sp_rename N'dbo.Tmp_Compras', N'Compras', 'OBJECT' 
GO
ALTER TABLE dbo.Compras ADD CONSTRAINT
	PK_Compras PRIMARY KEY CLUSTERED 
	(
	idCompra
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
