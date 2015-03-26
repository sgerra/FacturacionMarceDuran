USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[PagosProveedores_insertarRegistro]    Script Date: 03/01/2015 9:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PagosProveedores_EliminarRegistro]
@ppr_nropago int,
@ppr_codprov int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   DELETE dbo.PagosProveedores 
   WHERE ppr_nropago=@ppr_nropago and ppr_codprov=@ppr_codprov	 
END

