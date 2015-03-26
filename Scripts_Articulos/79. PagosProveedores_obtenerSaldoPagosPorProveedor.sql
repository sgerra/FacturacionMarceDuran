USE FACTURACION
GO

ALTER PROCEDURE PagosProveedores_obtenerSaldoPagosPorProveedor
@idproveedor int
AS

SELECT isnull(SUM(ppr_impototal),0)as Saldo FROM PagosProveedores WHERE PagosProveedores.ppr_codprov=@idproveedor

