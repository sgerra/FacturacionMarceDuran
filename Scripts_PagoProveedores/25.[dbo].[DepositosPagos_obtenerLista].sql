USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Efectivo_obtenerLista]    Script Date: 18/12/2014 11:10:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DepositosPagos_obtenerLista]
@tpo_moneda int
AS

SELECT * FROM deposito_pagos 
