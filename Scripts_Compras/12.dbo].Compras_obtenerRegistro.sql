USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerArticulo]    Script Date: 29/10/2014 02:09:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Compras_obtenerRegistro]
--declare
@lngIdCompra int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Compras 
	WHERE  (idCompra = @lngIdCompra)
END

