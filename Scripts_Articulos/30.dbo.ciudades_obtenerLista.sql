/****** Script para el comando SelectTopNRows de SSMS  ******/
Use Facturacion
GO

CREATE PROCEDURE ciudades_obtenerLista
@idProvincia int

AS

SELECT * from Ciudades WHERE idProvincia=@idprovincia