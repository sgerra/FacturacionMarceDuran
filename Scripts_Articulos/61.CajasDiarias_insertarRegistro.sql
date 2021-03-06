USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[CajaDiaria_insertarCajaDiaria]    Script Date: 29/01/2015 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CajasDiarias_insertarRegistro]
@caj_id int,
@caj_f_apertura datetime,
@caj_h_apertura datetime,
@caj_f_cierre datetime,
@caj_h_cierre datetime, 
@caj_cerrada char(1), 
@caj_idusuario int,
@caj_saldoinicial decimal(18,2),
@caj_saldofinal decimal(18,2) ,
@caj_idsucursal int
AS
INSERT INTO [Facturacion].[dbo].[CajaDiaria]
           (caj_f_apertura
           ,caj_h_apertura
           ,caj_f_cierre
           ,caj_h_cierre
           ,caj_cerrada
           ,caj_idusuario
           ,caj_saldoinicial
           ,caj_saldofinal
		   ,caj_idSucursal)
     VALUES
           (@caj_f_apertura,
           @caj_h_apertura,
           @caj_f_cierre,
           @caj_h_cierre,
           @caj_cerrada, 
           @caj_idusuario,
           @caj_saldoinicial, 
           @caj_saldofinal,
		   @caj_idsucursal )


		   set @caj_id=@@IDENTITY

		   select @caj_id as caj_id