USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[SaldosProve_actualizarRegistro]    Script Date: 12/01/2015 13:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SaldosProve_actualizarRegistro]
@sal_idprove integer,
@sal_saldo float,
@sal_saldoini  float,
@sal_idsociedad int
AS

UPDATE SaldosProve
SET sal_saldo=@sal_saldo,
    sal_saldoini=@sal_saldoini
	 
WHERE sal_idprove = @sal_idprove

