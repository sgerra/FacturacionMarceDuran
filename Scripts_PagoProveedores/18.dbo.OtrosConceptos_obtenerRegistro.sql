USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_obtenerRegistro]    Script Date: 10/12/2014 6:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[OtrosConceptos_obtenerRegistro]
--declare
@poc_id int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Pagos_OtrosConceptos 
	WHERE  (poc_id = @poc_id)
END