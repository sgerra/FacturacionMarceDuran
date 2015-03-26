USE FACTURACION
GO

ALTER PROCEDURE OtrosConceptos_obtenerSaldoPorProveedor
@idproveedor int
AS

SELECT isnull(SUM(poc_monto),0)as Saldo FROM Pagos_OtrosConceptos WHERE Pagos_OtrosConceptos.poc_idprove=@idproveedor

