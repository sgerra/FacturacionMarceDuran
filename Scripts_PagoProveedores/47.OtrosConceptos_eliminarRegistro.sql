use facturacion
go

CREATE PROCEDURE OtrosConceptos_eliminarRegistro
@poc_nropago int

AS

DELETE FROM Pagos_OtrosConceptos
WHERE poc_nropago=@poc_nropago

