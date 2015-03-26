use facturacion
go

CREATE PROCEDURE Efectivo_eliminarRegistro
@pde_nropago int

AS

DELETE FROM Cheques
WHERE pde_nropago=@pde_nropago

