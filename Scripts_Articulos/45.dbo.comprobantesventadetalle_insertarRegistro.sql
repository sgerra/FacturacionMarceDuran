USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[insert_comprobantes_venta_detalle]    Script Date: 26/01/2015 19:36:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[comprobantesventadetalle_insertarRegistro]
	(@cvd_nrocom 	[int],
	 @cvd_codart 	[varchar](50),
	 @cvd_descart 	[varchar](100),
	 @cvd_cantidad 	[float],
	 @cvd_precunit 	[float],
	 @cvd_totart 	[float],
	 @cvd_idrubro 	[int])
AS INSERT INTO [facturacion].[dbo].[comprobantes_venta_detalle] 
	 ( [cvd_nrocom],
	 [cvd_codart],
	 [cvd_descart],
	 [cvd_cantidad],
	 [cvd_precunit],
	 [cvd_totart],
     [cvd_idrubro] ) 
 
VALUES 
	( @cvd_nrocom,
	 @cvd_codart,
	 @cvd_descart,
	 @cvd_cantidad,
	 @cvd_precunit,
	 @cvd_totart,
	 @cvd_idrubro )
