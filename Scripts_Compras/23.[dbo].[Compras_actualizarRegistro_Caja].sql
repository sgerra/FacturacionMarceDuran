USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Compras_insertarRegistro]    Script Date: 13/11/2014 03:40:57 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Compras_actualizarRegistro]
--declare
@IdCompra int,
@NroFactura varchar(50),
@Fecha datetime,
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
@total decimal(18,2)


--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.Compras 
	set nrofactura=@NroFactura,
	    fecha=@Fecha,
		idcondpago=@idCondPago,
		idtipofact=@idTipoFact,
		idestado=@idestado,
		idproveedor=@idProveedor,
		observaciones=@observaciones,
		PbaseTot=@PbaseTot,
		IvaTot=@IvaTot,
		ImpIntTot=@ImpIntTot,
		percepIvaTot=@percepIvaTot,
		percepIBTot=@percepIBTot,
		descuentoTot=@descuentoTot,
		total=@total
	WHERE idCompra=@IdCompra
	select @IdCompra as id_Compra
END

