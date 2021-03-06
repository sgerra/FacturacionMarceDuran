/*
   lunes, 2 de marzo de 201511:08:14
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
ALTER TABLE dbo.comprobantes_venta ADD
	cvt_condicionVenta int NULL,
	cvt_remito varchar(50) NULL,
	cvt_impuestos float(53) NULL,
	cvt_subtotalI float(53) NULL,
	cvt_montoIva float(53) NULL,
	cvt_nroFactura varchar(50) NULL,
	cvt_pagada bit NULL
GO
ALTER TABLE dbo.comprobantes_venta SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
