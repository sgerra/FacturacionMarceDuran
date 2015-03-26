USE Facturacion
GO

CREATE PROCEDURE BancosGenerales_obtenerRegistro
@ban_idbanco int
AS


select * from BancosGenerales 
WHERE ban_idbanco=@ban_idbanco
