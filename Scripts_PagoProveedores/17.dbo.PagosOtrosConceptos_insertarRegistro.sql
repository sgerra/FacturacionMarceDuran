USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_insertarRegistro]    Script Date: 09/12/2014 12:03:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PagosOtrosConceptos_insertarRegistro]
--declare
@poc_id int,
@poc_fecha datetime,
@poc_idprove int,
@poc_descripcion varchar(50),
@poc_monto float,
@poc_comprobante nvarchar(50),
@poc_nropago int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Pagos_OtrosConceptos 
	(poc_fecha,poc_idprove,poc_descripcion,poc_monto,poc_comprobante,poc_nropago)
	VALUES
	(@poc_fecha,@poc_idprove,@poc_descripcion,@poc_monto,@poc_comprobante,@poc_nropago)
	
	set @poc_id  = @@identity 
	select @poc_id as poc_id
END

