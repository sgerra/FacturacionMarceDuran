USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[PagosProveedoresDetalles_obtenerLista]    Script Date: 23/02/2015 12:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PagosProveedoresDetalles_obtenerLista]
@nropago int

AS

SELECT  * From PagosProveedores_Detalles,Compras,tposEstadosFactura 
where ppd_idcompra=compras.idCompra AND Compras.idEstado=tposEstadosFactura.idestado AND ppd_nropago=@nropago 


