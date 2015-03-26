USe Facturacion
Go

CREATE PROCEDURE PAgosProveedores_obtenerRegistro
@ppr_idpago int

AS

SELECT * FROM PagosProveedores
WHERE ppr_idpago=@ppr_idpago
