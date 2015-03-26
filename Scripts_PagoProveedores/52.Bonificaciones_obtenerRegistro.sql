Use Facturacion

GO

CREATE PROCEDURE Bonificaciones_obtenerRegistro
@bon_idbon int
AS

SELECT * FROM Bonificaciones
WHERE bon_idbon=@bon_idbon
