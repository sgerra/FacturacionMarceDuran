USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[StocPorDeposito_eliminarRegistro]    Script Date: 19/01/2015 20:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[StockPorDeposito_eliminarRegistro]
@iddeposito int,
@codart int

AS

DELETE FROM StockPorDeposito
WHERE [Iddeposito]=@iddeposito and [codart]=@codart