USE FACTURACION
GO

CREATE PROCEDURE Perfiles_obtenerRegistro
@prf_id int

AS

SELECT * FROM Perfiles
WHERE prf_id=@prf_id