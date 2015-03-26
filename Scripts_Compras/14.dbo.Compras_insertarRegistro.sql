USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[TposEstadosFactura_obtenerLista]    Script Date: 29/10/2014 22:10:10 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[Compras_insertarRegistro] 
@idCompra int,
@nrofactura varchar(50),
@fecha datetime,
@idcondpago int,
@idtipofact int,
@idestado int,
@idproveedor int,
@totalcompra decimal(18,2),
@observaciones varchar(1000)
AS
INSERT INTO dbo.compras
(nrofactura,fecha,idcondpago,idtipofact,idestado,idproveedor,totalcompra,observaciones)
VALUES
(@nrofactura,@fecha,@idcondpago,@idtipofact,@idestado,@idproveedor,@totalcompra,@observaciones)
