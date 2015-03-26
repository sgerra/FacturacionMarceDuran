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
CREATE PROCEDURE [dbo].[ComprasDetalles_insertarRegistro]
--declare
@idDet int,
@idcompra int,
@codart int,
@descri varchar(100),
@cantidad int,
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
	INSERT INTO [dbo].[Compras_Detalles]
	(idcompra,codart,descri,cantidad,idunidad,precio,porciva,montoiva,porcimpint,montoimpint,porcdto,montodto,punitfinal,total)
	VALUES
	(@idcompra,@codart,@descri,@cantidad,@idunidad,@precio,@porciva,@montoiva,@porcimpint,@montoimpint,@porcdto,@montodto,@punitfinal,@total)
END

