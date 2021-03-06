USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[comprobantesventa_insertarRegistro]    Script Date: 02/03/2015 15:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[comprobantesventa_insertarRegistro]
@cvt_id int,
@cvt_nrocom int,
@cvt_tipcom int,
@cvt_idcliente int,
@cvt_fecha datetime,
@cvt_idcondiva int,
@cvt_pbase float,
@cvt_porciva float,
@cvt_totcom float,
@cvt_idusuario int,
@cvt_origen char(1),
@cvt_dto float,
@cvt_totaldto float,
@cvt_formapago int,
@cvt_condicionventa int,
@cvt_remito varchar(50),
@cvt_impuestos float,
@cvt_subTotalI float,
@cvt_MontoIva float,
@cvt_NroFactura varchar(50),
@cvt_pagada bit

AS

INSERT INTO comprobantes_venta
VALUES (@cvt_nrocom,@cvt_tipcom,@cvt_idcliente,@cvt_fecha,@cvt_idcondiva,@cvt_pbase,@cvt_porciva,@cvt_totcom,@cvt_idusuario ,@cvt_origen,@cvt_dto,@cvt_totaldto ,@cvt_formapago,@cvt_condicionventa ,@cvt_remito ,@cvt_impuestos ,@cvt_subTotalI ,@cvt_MontoIva,@cvt_NroFactura,@cvt_pagada)

