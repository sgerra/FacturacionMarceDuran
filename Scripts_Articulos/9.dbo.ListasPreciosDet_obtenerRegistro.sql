USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ListasPreciosDet_obtenerRegistro]    Script Date: 19/01/2015 11:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ListasPreciosDet_obtenerRegistro]
@codart int

AS

Select * from Listaprecios_det lpd
WHERE lpd.lpd_art_codart=@codart 
ORDER BY lpd_lpr_id
