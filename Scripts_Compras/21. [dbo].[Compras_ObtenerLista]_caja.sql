USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_ObtenerLista]    Script Date: 12/11/2014 09:01:13 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Compras_ObtenerLista]

AS

SELECT c.idcompra as IdCompra,c.fecha as Fecha,p.NombreProveedor as Proveedor,c.total as Total,tp.idestado as idestado,tp.descri as Estado  
FROM [Facturacion].[dbo].[Compras] c,[Facturacion].[dbo].[Proveedores]  p,[Facturacion].[dbo].[TposEstadosFactura]tp
where c.idProveedor=p.idProveedor AND
      c.idEstado=tp.idestado 
