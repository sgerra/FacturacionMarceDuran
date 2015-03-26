USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ComprasDetalles_obtenerLista]    Script Date: 12/11/2014 11:50:35 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ComprasDetalles_obtenerLista]
--declare
@idCompra int

--set @idcompra=11
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Compras_Detalles cd,Unidades u
	WHERE  cd.idunidad=u.uni_id and (idcompra = @idcompra)
END

