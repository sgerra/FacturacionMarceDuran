USE [Facturacion]

GO

CREATE PROCEDURE PagosProveedores_obtenerLista
@idprov integer


AS

SELECT ppr_nropago, ppr_fecpago, ppr_comprobante, ppr_impototal
From PagosProveedores
Where ppr_codprov = @idprov
ORDER BY ppr_nropago
