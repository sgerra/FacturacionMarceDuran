USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[TraerDetalleCaja]    Script Date: 29/01/2015 8:56:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CajasDiariasDetalle_TraerDetalleCaja]
--declare
@fecha varchar(10),
@hora varchar(10),
@idusuario int


AS
declare @cadena varchar(20)
--set @fecha='03/09/2014'
--set @hora ='08:29:03'
--set @idusuario=4

set @cadena=@fecha + ' ' + @hora

SELECT * FROM comprobantes_venta cv,t_FormasPago tf
WHERE cvt_idusuario=@idusuario and cvt_fecha >= convert(datetime,@cadena,103) and tf.cod=cv.cvt_formaPago
order by cvt_nrocom

--print convert(datetime,@cadena,103)

