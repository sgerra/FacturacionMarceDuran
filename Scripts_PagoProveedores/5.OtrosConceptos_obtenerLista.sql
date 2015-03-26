USE Facturacion
GO

CREATE PROCEDURE OtrosConceptos_obtenerLista
@nropago int

AS

SELECT poc_fecha, poc_descripcion, poc_monto, poc_comprobante, poc_id
From Pagos_OtrosConceptos
Where poc_nropago =@nropago
                 
