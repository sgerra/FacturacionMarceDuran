use facturacion
go

CREATE PROCEDURE Cheques_eliminarRegistro
@pcp_nropago int

AS

DELETE FROM Cheques
WHERE pcp_nropago=@pcp_nropago

