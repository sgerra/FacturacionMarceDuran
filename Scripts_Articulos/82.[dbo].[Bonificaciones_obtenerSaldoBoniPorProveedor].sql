USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Bonificaciones_obtenerSaldoBoniPorProveedor]    Script Date: 21/02/2015 10:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Bonificaciones_obtenerSaldoBoniPorProveedor]
@idproveedor int
AS

SELECT isnull(SUM(bon_monto),0)as Saldo FROM Bonificaciones WHERE Bonificaciones.bon_nroprove=@idproveedor

