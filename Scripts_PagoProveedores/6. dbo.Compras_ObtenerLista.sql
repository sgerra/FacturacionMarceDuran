USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_ObtenerLista]    Script Date: 03/12/2014 11:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Compras_ObtenerLista]

AS

SELECT c.idcompra as IdCompra,c.fecha as Fecha,p.NombreProveedor as Proveedor,c.total as Total,tp.idestado as idestado,tp.descri as Estado,
       c.idProveedor,pagada,isnull(NroFactura,'0')as NroFactura  
FROM [Facturacion].[dbo].[Compras] c,[Facturacion].[dbo].[Proveedores]  p,[Facturacion].[dbo].[TposEstadosFactura]tp
where c.idProveedor=p.idProveedor AND
      c.idEstado=tp.idestado 
