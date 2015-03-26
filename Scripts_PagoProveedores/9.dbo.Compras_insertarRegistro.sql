USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_insertarRegistro]    Script Date: 05/12/2014 16:03:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Compras_insertarRegistro]
--declare
@IdCompra int,
@NroFactura varchar(50),
@Fecha datetime,
@FechaEntrega datetime,
@idCondPago int,
@idTipoFact int,
@idEstado int,
@idProveedor int,
@observaciones varchar(1000),
@PbaseTot decimal(18,2),
@IvaTot decimal(18,2),
@ImpIntTot decimal(18,2),
@percepIvaTot decimal(18,2),
@percepIBTot decimal(18,2),
@descuentoTot decimal(18,2),
@total decimal(18,2),
@pagada bit


--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Compras 
	(nrofactura,fecha,fechaentrega,idcondpago,idtipofact,idestado,idproveedor,observaciones,PbaseTot,IvaTot,ImpIntTot,percepIvaTot,percepIBTot,descuentoTot,total,pagada)
	VALUES
	(@nrofactura,@fecha,@fechaentrega,@idcondpago,@idtipofact,@idestado,@idproveedor,@observaciones,@PbaseTot,@IvaTot,@ImpIntTot,@percepIvaTot,@percepIBTot,@descuentoTot,@total,@pagada)
	
	set @idCompra  = @@identity 
	select @IdCompra as id_Compra
END

