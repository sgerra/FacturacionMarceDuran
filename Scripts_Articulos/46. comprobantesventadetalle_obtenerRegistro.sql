/****** Script para el comando SelectTopNRows de SSMS  ******/
USE FACTURACION
GO


CREATE PROCEDURE comprobantesventadetalle_obtenerRegistro
@cvd_nrocom int

AS

SELECT *  FROM [Facturacion].[dbo].[comprobantes_venta_detalle]
WHERE cvd_nrocom=@cvd_nrocom