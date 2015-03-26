USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_obtenerRegistro]    Script Date: 29/10/2014 22:45:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ComprasDetalles_obtenerLista]
--declare
@idCompra int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Compras_Detalles
	WHERE  (idcompra = @idcompra)
END

