USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_obtenerRegistro]    Script Date: 09/12/2014 11:59:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PagosOtrosConceptos_obtenerRegistro]
--declare
@lngid int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Pagos_OtrosConceptos
	WHERE  (poc_id = @lngId)
END

