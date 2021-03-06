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
ALTER PROCEDURE [dbo].[Cheques_insertarRegistro]
--declare
@pcp_idpcp int,
@pcp_nrocheque varchar(50),
@pcp_banco int,
@pcp_monto float,
@pcp_fecemi datetime,
@pcp_fecpago datetime,
@pcp_soc_id int,
@pcp_nropago int,
@pcp_origen char(1)



--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Cheques
	(pcp_nrocheque,pcp_banco,pcp_monto,pcp_fecemi,pcp_fecpago,pcp_soc_id,pcp_nropago,pcp_origen)
	VALUES
	(@pcp_nrocheque,@pcp_banco,@pcp_monto,@pcp_fecemi,@pcp_fecpago,@pcp_soc_id,@pcp_nropago,@pcp_origen)
	
	set @pcp_idpcp  = @@identity 
	select @pcp_idpcp as pcp_idpcp
END

