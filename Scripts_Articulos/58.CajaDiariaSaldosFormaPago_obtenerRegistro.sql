USE FACTURACION
GO

CREATE PROCEDURE CajaDiariaSaldosFormaPago_obtenerRegistro
@cds_id int

AS

SELECT * FROM CajaDiaria_SaldosFormaPAgo
WHERE cds_id=@cds_id
