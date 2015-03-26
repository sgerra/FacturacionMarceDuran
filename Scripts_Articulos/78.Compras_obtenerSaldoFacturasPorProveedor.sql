USE FACTURACION
GO

CREATE PROCEDURE Compras_obtenerSaldoFacturasPorProveedor
@idproveedor int
AS

SELECT SUM(Saldo)as Saldo FROM Compras WHERE Compras.idProveedor=@idproveedor
