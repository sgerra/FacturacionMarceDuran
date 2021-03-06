USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ComprasDetalles_actualizarRegistro]    Script Date: 26/11/2014 17:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ComprasDetalles_actualizarRegistro]
--declare
@idDet int,
@idcompra int,
@codart int,
@descri varchar(100),
@cantidad decimal(18,2),
@idunidad int,
@precio decimal(18,2),
@porciva decimal(18,2),
@montoiva decimal (18,2),
@porcImpInt decimal(18,2),
@montoImpInt decimal(18,2),
@porcdto decimal(18,2),
@montoDto decimal(18,2),
@punitfinal decimal(18,2),
@total decimal(18,2)


--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Compras_Detalles]
	SET codart=@codart,
	    descri=@descri,
		cantidad=@cantidad,
		idunidad=@idunidad,
		precio=@precio,
		porciva=@porciva,
		montoiva=@montoiva,
		porcimpint=@porcImpInt,
		montoimpint=@montoImpInt,
		porcdto=@porcdto,
		montodto=@montoDto,
		punitfinal=@punitfinal,
		total=@total
	WHERE iddet=@iddet
END

