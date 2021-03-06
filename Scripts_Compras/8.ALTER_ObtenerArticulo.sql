USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerArticulo]    Script Date: 23/10/2014 02:13:30 p.m. ******/
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
                         Articulos.idetiqueta, Unidades.uni_id AS Expr1, Unidades.uni_descripcion
FROM            Articulos INNER JOIN
                         Unidades ON Articulos.uni_id = Unidades.uni_id
WHERE        (Articulos.codart = @codart)
END

