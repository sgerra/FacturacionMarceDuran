USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[StockPorDeposito_insertarRegistro]    Script Date: 19/01/2015 15:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StockPorDeposito_actualizarRegistro]
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
 


