/****** Script para el comando SelectTopNRows de SSMS  ******/
USE FACTURACION
GO

CREATE PROCEDURE tFactura_obtenerRegistro
@codigo varchar(1)

AS

SELECT * FROM t_factura WHERE codigo like @codigo