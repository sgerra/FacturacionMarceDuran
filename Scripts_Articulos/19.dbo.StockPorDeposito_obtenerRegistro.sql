USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[StockPorDeposito_obtenerRegistro]    Script Date: 19/01/2015 20:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[StockPorDeposito_obtenerRegistro]
@codart int,
@iddeposito int

AS

SELECT * FROM StockPorDeposito
WHERE codart=@codart and Iddeposito=@iddeposito
