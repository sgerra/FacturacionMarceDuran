USE FACTURACION
GO

CREATE PROCEDURE comprobantesVenta_obtenerRegistro
@cvt_nrocom int

AS

SELECT * FROM comprobantes_venta WHERE cvt_nrocom=@cvt_nrocom