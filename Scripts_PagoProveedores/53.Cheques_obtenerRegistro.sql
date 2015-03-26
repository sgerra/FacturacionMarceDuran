use facturacion
go

CREATE PROCEDURE Cheques_obtenerRegistro
@pcp_idpcp int
as

SELECT * FROM Cheques
WHERE pcp_idpcp=@pcp_idpcp
