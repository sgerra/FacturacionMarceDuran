/****** Script para el comando SelectTopNRows de SSMS  ******/
Use Facturacion
GO

alter PROCEDURE Provincias_obtenerLista


AS

SELECT idprovincia,provincia from Provincias 