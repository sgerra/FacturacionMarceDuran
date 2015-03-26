/****** Script para el comando SelectTopNRows de SSMS  ******/
Use [Facturacion ]

GO

ALTER PROCEDURE Compras_obtenerLista

AS

SELECT c.idcompra as IdCompra,c.fecha as Fecha,p.NombreProveedor as Proveedor,c.total as Total,tp.descri as Estado  
FROM [Facturacion].[dbo].[Compras] c,[Facturacion].[dbo].[Proveedores]  p,[Facturacion].[dbo].[TposEstadosFactura]tp
where c.idProveedor=p.idProveedor AND
      c.idEstado=tp.idestado 
