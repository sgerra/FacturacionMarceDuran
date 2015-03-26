USE FACTURACION
GO

CREATE PROCEDURE Usuarios_obtenerRegistro
@usu_id int

AS

SELECT * FROM Usuarios WHERE usu_id=@usu_id
