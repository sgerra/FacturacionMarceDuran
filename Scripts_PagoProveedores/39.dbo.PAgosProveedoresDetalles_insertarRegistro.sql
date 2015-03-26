USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[PAgosProveedoresDetalles_insertarRegistro]    Script Date: 30/12/2014 14:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PAgosProveedoresDetalles_insertarRegistro]
@ppd_iddet int,
@ppd_tipfac varchar(50),
@ppd_nrofac varchar(50),
@ppd_totalfac float,
@ppd_idcompra int,
@ppd_deposito varchar(50),
@ppd_feccom datetime,
@ppd_nropago int

AS

INSERT INTO PagosProveedores_Detalles
(ppd_tipfac,ppd_nrofac,ppd_totalfac,ppd_idcompra,ppd_deposito,ppd_feccom,ppd_nropago)
VALUES
(@ppd_tipfac,@ppd_nrofac,@ppd_totalfac,@ppd_idcompra,@ppd_deposito,@ppd_feccom,@ppd_nropago)

set @ppd_iddet=@@IDENTITY
select @ppd_iddet as ppd_iddet


