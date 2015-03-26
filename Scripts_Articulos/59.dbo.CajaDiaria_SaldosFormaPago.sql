USE [Facturacion]
GO
CREATE PROCEDURE CajadiariaSaldosFormaPago_insertarRegistro
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

GO


