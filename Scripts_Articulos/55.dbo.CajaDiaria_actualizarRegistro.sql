USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[clientes_actualizarRegistro]    Script Date: 29/01/2015 14:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CajasDiarias_actualizarRegistro]
@caj_id int,
@caj_f_apertura as datetime,
@caj_h_apertura datetime,
@caj_f_cierre datetime,
@caj_h_cierre datetime,
@caj_cerrada char(1),
@caj_idusuario int,
@caj_saldoinicial decimal(18,2),
@caj_saldoFinal decimal(18,2),
@caj_idsucursal int


AS

UPDATE [Facturacion].[dbo].[CajaDiaria]
SET caj_f_cierre =@caj_f_cierre ,
	caj_h_cierre=@caj_h_cierre ,
	caj_cerrada=@caj_cerrada ,
	caj_saldoFinal =@caj_saldoFinal 

	WHERE caj_id=@caj_id AND
	      caj_idSucursal=@caj_idsucursal 
           
           