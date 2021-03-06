USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ComprasDetalles_actualizarRegistro]    Script Date: 26/02/2015 10:00:46 ******/
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
@porcUtil decimal(18,2),
@montoUtil decimal(18,2),
@porcdto decimal(18,2),
@montoDto decimal(18,2),
@punitfinal decimal(18,2),
@total decimal(18,2),
@porcPercep decimal(18,2),
@montoPercep decimal(18,2)


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
		porcUtil=@porcUtil,
		montoUtil=@montoUtil,
		porcdto=@porcdto,
		montodto=@montoDto,
		punitfinal=@punitfinal,
		total=@total,
		porcpercep=@porcPercep,
		montoPercep=@montoPercep
	WHERE iddet=@iddet
END

