USE Facturacion
GO

CREATE PROCEDURE StockPorDeposito_obtenerLista
--declare
@codart int

--set @codart=10
AS

SELECT * FROM StockPorDeposito 
WHERE codart=@codart
