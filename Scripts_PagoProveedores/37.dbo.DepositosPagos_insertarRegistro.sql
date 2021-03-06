USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_insertarRegistro]    Script Date: 28/12/2014 19:47:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DepositosPagos_insertarRegistro]
--declare
@dep_id int,
@dep_idbanco int,
@dep_nroboleta int,
@dep_fecha datetime,
@dep_totaldepo float,
@dep_nropago int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.deposito_pagos 
	(dep_idbanco,dep_nroboleta,dep_fecha,dep_totaldepo,dep_nropago)
	VALUES
	(@dep_idbanco,@dep_nroboleta,@dep_fecha,@dep_totaldepo,@dep_nropago)
	
	set @dep_id  = @@identity 
	select @dep_id as dep_id
END

