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
CREATE PROCEDURE [dbo].[Efectivo_obtenerRegistro]
--declare
@pde_idpde int
--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Efectivo WHERE pde_idpde=@pde_idpde

END

