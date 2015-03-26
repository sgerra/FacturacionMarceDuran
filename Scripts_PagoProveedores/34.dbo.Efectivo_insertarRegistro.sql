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
CREATE PROCEDURE [dbo].[Efectivo_insertarRegistro]
--declare
@pde_idpde int,
@pde_tpomoneda int,
@pde_monto float,
@pde_nropago int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Efectivo
	(pde_tpomoneda,pde_monto,pde_nropago)
	VALUES
	(@pde_tpomoneda,@pde_monto,@pde_nropago)
	
	set @pde_idpde  = @@identity 
	select @pde_idpde as pde_idpde
END

