USE [Facturacion]
GO

CREATE PROCEDURE bonificaciones_obtenerBonificacionesPorProve
@nroprove int

AS

SELECT bon_nrobon, bon_concepto, bon_monto,  bon_usada, bon_fecha, bon_comprobante
From bonificaciones
WHERE(bon_usada = 0) AND  bon_nroprove = @nroprove
