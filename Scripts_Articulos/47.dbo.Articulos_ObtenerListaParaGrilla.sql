USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_ObtenerListaParaGrilla]    Script Date: 28/01/2015 14:53:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Articulos_ObtenerListaParaGrilla]
@idlista int
AS
SELECT * FROM ARTICULOS,Listaprecios_det
WHERE lpd_lpr_id=@idlista and codart=lpd_art_codart


