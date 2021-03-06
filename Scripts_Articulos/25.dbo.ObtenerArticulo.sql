USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerArticulo]    Script Date: 20/01/2015 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ObtenerArticulo]
--declare
@codart int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT        Articulos.codart, Articulos.[desc], Articulos.cod, Articulos.rubro, Articulos.costo, Articulos.activo, Articulos.signo, Articulos.idproveedor, Articulos.uni_id, 
                         Articulos.idetiqueta, Unidades.uni_id AS idUnidad, Unidades.uni_descripcion, Listaprecios_det.lpd_precioC, Listaprecios_det.lpd_porciva, 
                         Listaprecios_det.lpd_Montoiva,Articulos.costogranel,Articulos.unidadesgranel,Articulos.imagen
FROM            Articulos INNER JOIN
                         Unidades ON Articulos.uni_id = Unidades.uni_id INNER JOIN
                         Listaprecios_det ON Articulos.codart = Listaprecios_det.lpd_art_codart
WHERE        (Articulos.codart = @codart) AND (Listaprecios_det.lpd_lpr_id = 1)
END

