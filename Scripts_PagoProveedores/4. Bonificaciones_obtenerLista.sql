USE Facturacion
GO

CREATE PROCEDURE Bonificaciones_obtenerLista
@nroPago int

AS

SELECT bon_nrobon, bon_concepto, bon_monto, bon_NroPago, bon_usada,bon_fecha,bon_comprobante
From bonificaciones
WHERE bon_nropago =@nropago
            