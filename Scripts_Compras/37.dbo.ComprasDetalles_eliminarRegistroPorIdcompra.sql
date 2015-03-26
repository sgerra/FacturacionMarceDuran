USe facturacion
go

CREATE PROCEDURE ComprasDetalles_eliminarRegistroPorIdcompra
@idCompra int

AS

DELETE FROM Compras_Detalles where idCompra=@idCompra
