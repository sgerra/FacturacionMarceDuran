USE Facturacion
GO

ALTER PROCEDURE [dbo].[SaldosProve_insertarRegistro]
@sal_idprove integer,
@sal_saldo float,
@sal_saldoini  float,
@sal_idsociedad int
AS

INSERT INTO SaldosProve(sal_idprove,sal_saldo,sal_saldoini,sal_idsociedad)
VALUES (@sal_idprove,@sal_saldo,@sal_saldoini,@sal_idsociedad)

