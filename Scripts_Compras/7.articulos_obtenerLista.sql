USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_ObtenerLista]    Script Date: 23/10/2014 08:52:33 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[articulos_obtenerLista]
AS
SELECT * FROM ARTICULOS
