USe Facturacion
GO

CREATE PROCEDURE SucursalesCajas_obtenerLista
@idsucursal int

AS

SELECT * FROM sucursalescajas where idsucursal=@idsucursal
