USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[CajadiariaSaldosFormaPago_insertarRegistro]    Script Date: 29/01/2015 18:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CajadiariaSaldosFormaPago_insertarRegistro]
@cds_id int,
@cds_caj_id int,
@cds_codfp int,
@cds_saldo float

AS

INSERT INTO [dbo].[CajaDiaria_SaldosFormaPago]
           ([cds_codfp]
           ,[cds_saldo])
     VALUES
           (@cds_codfp, 
            @cds_saldo )

	   set @cds_caj_id=@@IDENTITY
	   select @cds_caj_id as cds_caj_id

