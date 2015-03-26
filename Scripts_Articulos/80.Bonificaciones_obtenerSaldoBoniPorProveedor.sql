USE FACTURACION
GO

CREATE PROCEDURE Bonificaciones_obtenerSaldoBoniPorProveedor
@idproveedor int
AS

SELECT SUM(bon_monto)as Saldo FROM Bonificaciones WHERE Bonificaciones.bon_nroprove=@idproveedor

