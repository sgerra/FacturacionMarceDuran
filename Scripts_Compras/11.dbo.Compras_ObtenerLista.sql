USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_ObtenerLista]    Script Date: 29/10/2014 02:08:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Compras_ObtenerLista]
AS
SELECT * FROM ARTICULOS
