USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[PagosProveedores_insertarRegistro]    Script Date: 03/01/2015 9:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PagosProveedoresDetalles_EliminarRegistro]
@ppd_nropago int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   DELETE dbo.PagosProveedores_Detalles
   WHERE ppd_nropago=@ppd_nropago 
END

