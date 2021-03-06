USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_ObtenerDetalle]    Script Date: 25/02/2015 9:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Articulos_ObtenerDetalle]
AS
SELECT        art.codart, art.[desc], art.cod, art.rubro, art.costo, art.activo, art.signo, art.idproveedor, art.uni_id, art.idetiqueta, art.costogranel, art.unidadesgranel, art.imagen, u.uni_id AS Expr1, u.uni_descripcion, stk.idst, 
                         stk.Iddeposito, stk.codart AS Expr2, stk.StockInicial, stk.StockActual, stk.Stockminimo, stk.Stockmaximo, stk.FechaInv, d.idDeposito AS Expr3, d.deposito, d.comentario, d.sociedad, d.eliminado, 
                         Listaprecios_det.lpd_precioC AS Expr4, Listaprecios_det.lpd_porcdesc, Listaprecios_det.lpd_montodesc, Listaprecios_det.lpd_porcpercep, Listaprecios_det.lpd_montopercep, 
                         Listaprecios_det.lpd_precioSubTotal, Listaprecios_det.lpd_porcUtil, Listaprecios_det.lpd_utilidad, Listaprecios_det.lpd_porciva, Listaprecios_det.lpd_Montoiva, Listaprecios_det.lpd_precioVta, 
                         Listaprecios_det.lpd_fecmodipr, Listaprecios_det.lpd_idusuario, Listaprecios_det.lpd_modificado
FROM            Listaprecios_det INNER JOIN
                         Articulos AS art INNER JOIN
                         Unidades AS u ON art.uni_id = u.uni_id ON Listaprecios_det.lpd_art_codart = art.codart LEFT OUTER JOIN
                         Depositos AS d INNER JOIN
                         StockPorDeposito AS stk ON d.idDeposito = stk.Iddeposito ON art.codart = stk.codart
WHERE lpd_lpr_id=1
ORDER BY art.[desc]