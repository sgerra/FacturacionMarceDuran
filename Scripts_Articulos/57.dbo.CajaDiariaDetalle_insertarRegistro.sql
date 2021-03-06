USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[CajaDiariaDetalle_insertarRegistro]    Script Date: 29/01/2015 14:32:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CajaDiariaDetalle_insertarRegistro]
@cdd_id int,
@cdd_caj_id int,
@cdd_nromov int,
@cdd_cvt_nrocom int,
@cdd_cvt_totcom decimal(18,2),
@cdd_descripcion varchar(200),
@cdd_entrada int,
@cdd_salida int

AS

INSERT INTO CajaDiaria_Detalle
(cdd_caj_id,
 cdd_nromov,
 cdd_cvt_nrocom,
 cdd_cvt_totcom ,
 cdd_descripcion,
 cdd_entrada ,
 cdd_salida )

VALUES
(@cdd_caj_id, 
@cdd_nromov, 
@cdd_cvt_nrocom,
@cdd_cvt_totcom,
@cdd_descripcion,
@cdd_entrada ,
@cdd_salida )

