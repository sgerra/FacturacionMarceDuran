USE [Facturacion]
GO

CREATE PROCEDURE CajasDiarias_insertarRegsitro
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
INSERT INTO [dbo].[CajaDiaria]
           ([caj_f_apertura]
           ,[caj_h_apertura]
           ,[caj_f_cierre]
           ,[caj_h_cierre]
           ,[caj_cerrada]
           ,[caj_idusuario]
           ,[caj_saldoinicial]
           ,[caj_saldofinal]
           ,[caj_idSucursal])
     VALUES
           (@caj_f_apertura,
           @caj_h_apertura,
           @caj_f_cierre, 
           @caj_h_cierre,
           @caj_cerrada, 
           @caj_idusuario,
           @caj_saldoinicial,
           @caj_saldofinal,
           @caj_idSucursal)

		    set @caj_id  = @@identity 
	        select @caj_id as caj_id
GO


