USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_obtenerSaldoFacturasPorProveedor]    Script Date: 21/02/2015 10:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Compras_obtenerSaldoFacturasPorProveedor]
@idproveedor int
AS

SELECT isnull(SUM(Saldo),0)as Saldo FROM Compras WHERE Compras.idProveedor=@idproveedor
