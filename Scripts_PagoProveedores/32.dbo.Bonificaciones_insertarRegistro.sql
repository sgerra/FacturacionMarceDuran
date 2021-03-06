USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_insertarRegistro]    Script Date: 27/12/2014 11:18:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Bonificaciones_insertarRegistro]
--declare
@bon_Idbon int,
@bon_fecha datetime,
@bon_nro int,
@bon_nrobon varchar(50),
@bon_nroprove int,
@bon_concepto varchar(50),
@bon_monto float,
@bon_comprobante varchar(1),
@bon_usada int,
@bon_nropago int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Bonificaciones 
	(bon_fecha,bon_nro,bon_nrobon,bon_nroprove,bon_concepto,bon_monto,bon_comprobante,bon_usada,bon_nropago)
	VALUES
	(@bon_fecha,@bon_nro,@bon_nrobon,@bon_nroprove,@bon_concepto,@bon_monto,@bon_comprobante,@bon_usada,@bon_nropago)
	
	set @bon_Idbon  = @@identity 
	select @bon_Idbon as bon_idbon
END

