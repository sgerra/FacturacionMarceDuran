USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_ObtenerListaParaGrilla]    Script Date: 23/02/2015 14:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Articulos_ObtenerDetalle]
AS
SELECT * FROM ARTICULOS art, Unidades u
WHERE art.uni_id=u.uni_id


