USE FACTURACION
GO

CREATE PROCEDURE Perfiles_eliminarRegistro
@prf_id int



AS

DELETE Perfiles
WHERE prf_id=@prf_id