USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ListasPreciosDet_obtenerRegistro]    Script Date: 19/01/2015 13:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StockPorDeposito_insertarRegistro]
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
 


