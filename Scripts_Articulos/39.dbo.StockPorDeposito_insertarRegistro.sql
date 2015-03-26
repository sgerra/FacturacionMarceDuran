USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[StockPorDeposito_insertarRegistro]    Script Date: 26/01/2015 12:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[StockPorDeposito_insertarRegistro]
@idst int,
@iddeposito int,
@codart int,
@stockinicial float,
@stockActual float,
@stockminimo float,
@stockMaximo float,
@fechaInv datetime


AS

INSERT INTO StockPorDeposito
(Iddeposito,codart,StockInicial,StockActual,Stockminimo,Stockmaximo,FechaInv)
VALUES
(@Iddeposito,@codart,@StockInicial,@StockActual,@Stockminimo,@Stockmaximo,@FechaInv)
 


