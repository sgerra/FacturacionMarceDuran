USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_ObtenerDetalle]    Script Date: 24/02/2015 15:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Articulos_ObtenerDetalle]
AS
SELECT        art.codart, art.[desc], art.cod, art.rubro, art.costo, art.activo, art.signo, art.idproveedor, art.uni_id, art.idetiqueta, art.costogranel, art.unidadesgranel, art.imagen, u.uni_id AS Expr1, u.uni_descripcion, stk.idst, 
                         stk.Iddeposito, stk.codart AS Expr2, stk.StockInicial, stk.StockActual, stk.Stockminimo, stk.Stockmaximo, stk.FechaInv, d.idDeposito AS Expr3, d.deposito, d.comentario, d.sociedad, d.eliminado
FROM            Depositos AS d INNER JOIN
                         StockPorDeposito AS stk ON d.idDeposito = stk.Iddeposito RIGHT OUTER JOIN
                         Articulos AS art INNER JOIN
                         Unidades AS u ON art.uni_id = u.uni_id ON stk.codart = art.codart
ORDER BY codart

