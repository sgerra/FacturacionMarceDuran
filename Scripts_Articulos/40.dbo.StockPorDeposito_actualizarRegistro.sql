USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[StockPorDeposito_actualizarRegistro]    Script Date: 26/01/2015 12:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[StockPorDeposito_actualizarRegistro]
@idst int,
@iddeposito int,
@codart int,
@stockinicial float,
@stockActual float,
@stockminimo float,
@stockMaximo float,
@fechaInv datetime


AS

UPDATE StockPorDeposito
SET StockInicial=@stockinicial,StockActual=@stockActual,Stockminimo=@stockminimo,Stockmaximo=@stockMaximo,FechaInv=@fechaInv
WHERE codart=@codart and Iddeposito=@iddeposito
 


