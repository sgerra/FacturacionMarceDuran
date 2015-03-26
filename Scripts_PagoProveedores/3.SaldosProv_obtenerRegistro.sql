USE [Facturacion]

GO

CREATE PROCEDURE SaldosProve_obtenerRegistro
@idprov integer

AS

SELECT sal_saldoini
From SaldosProve
WHERE sal_idprove = @idprov
