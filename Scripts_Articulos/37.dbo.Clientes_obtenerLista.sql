USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Clientes_obtenerLista]    Script Date: 23/01/2015 9:56:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Clientes_obtenerLista]

AS

SELECT * FROM Clientes,Listaprecios lt
WHERE Clientes.cli_listaprecios=lt.lpr_id
order by cli_idcliente