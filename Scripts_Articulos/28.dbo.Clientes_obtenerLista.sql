use facturacion
go

CREATE PROCEDURE Clientes_obtenerLista

AS

SELECT * FROM Clientes
order by cli_idcliente