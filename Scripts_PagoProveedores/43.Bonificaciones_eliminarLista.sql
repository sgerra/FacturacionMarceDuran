use facturacion
go

CREATE PROCEDURE Bonificaciones_eliminarLista
@bon_nroprove int,
@bon_nropago int

AS

DELETE FROM Bonificaciones
WHERE bon_nroprove=@bon_nroprove and bon_nropago=@bon_nropago

