USE Facturacion
GO
ALTER PROCEDURE Efectivo_obtenerLista
@tpo_moneda int
AS

SELECT * FROM Efectivo WHERE pde_tpomoneda=@tpo_moneda
