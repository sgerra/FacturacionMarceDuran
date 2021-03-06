USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ComprasDetalles_insertarRegistro]    Script Date: 26/02/2015 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ComprasDetalles_insertarRegistro]
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
@MontoPercep decimal(18,2)


--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Compras_Detalles]
	(idcompra,codart,descri,cantidad,idunidad,precio,porciva,montoiva,porcUtil,montoUtil,porcdto,montodto,punitfinal,total,porcPercep,MontoPercep)
	VALUES
	(@idcompra,@codart,@descri,@cantidad,@idunidad,@precio,@porciva,@montoiva,@porcUtil,@montoUtil,@porcdto,@montodto,@punitfinal,@total,@porcPercep,@MontoPercep)
END

