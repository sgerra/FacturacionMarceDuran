USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[clientes_insertarRegistro]    Script Date: 23/01/2015 7:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[clientes_eliminarRegistro]
@cli_idcliente int
		   
AS

DELETE FROM Clientes WHERE cli_idcliente=@cli_idcliente