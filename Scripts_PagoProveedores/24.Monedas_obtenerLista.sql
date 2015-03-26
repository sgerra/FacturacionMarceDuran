USE Facturacion
Go

CREATE PROCEDURE Monedas_obtenerLista

AS

SELECT * from Monedas where mon_mostrar='S'