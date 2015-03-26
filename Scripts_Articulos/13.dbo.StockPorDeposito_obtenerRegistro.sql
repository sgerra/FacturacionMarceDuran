USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Bonificaciones_obtenerRegistro]    Script Date: 19/01/2015 14:12:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[StockPorDeposito_obtenerRegistro]
@codart int
AS

SELECT * FROM StockPorDeposito
WHERE codart=@codart
