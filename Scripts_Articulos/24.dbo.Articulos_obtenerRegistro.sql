USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_obtenerRegistro]    Script Date: 20/01/2015 9:58:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Articulos_obtenerRegistro]
@codart int

AS

SELECT * FROM Articulos where codart=@codart