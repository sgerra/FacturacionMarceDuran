USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[clientes_obtenerRegistro]    Script Date: 27/02/2015 15:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[clientes_obtenerDetalle]
--declare
@idcliente int
--set @idcliente=4
AS
SELECT       *
FROM            Listaprecios INNER JOIN
                         Clientes INNER JOIN
                         condicionesIVA ON Clientes.cli_cativa = condicionesIVA.idCondicionIVA ON Listaprecios.lpr_id = Clientes.cli_listaprecios INNER JOIN
                         Depositos ON Clientes.cli_idDeposito = Depositos.idDeposito INNER JOIN
                         Provincias ON Clientes.cli_idpcia = Provincias.idProvincia INNER JOIN
                         Ciudades ON Clientes.cli_idciudad = Ciudades.idCiudad
WHERE        (Clientes.cli_idcliente = @idcliente)
