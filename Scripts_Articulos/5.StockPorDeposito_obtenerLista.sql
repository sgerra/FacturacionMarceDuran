USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[StockPorDeposito_obtenerLista]    Script Date: 16/01/2015 18:55:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[StockPorDeposito_obtenerLista]
--declare
@codart int

--set @codart=10
AS

SELECT * FROM StockPorDeposito, Depositos 
WHERE codart=@codart and StockPorDeposito.Iddeposito=depositos.idDeposito
