USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_obtenerSaldoFacturasPorProveedor]    Script Date: 21/02/2015 11:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Compras_obtenerSaldoFacturasPorProveedor]
@idproveedor int
AS

SELECT isnull(SUM(total),0)as Saldo FROM Compras WHERE Compras.idProveedor=@idproveedor and idEstado <> 2
