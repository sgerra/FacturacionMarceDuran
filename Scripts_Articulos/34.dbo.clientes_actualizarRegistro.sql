USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[clientes_actualizarRegistro]    Script Date: 23/01/2015 7:36:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[clientes_actualizarRegistro]
           @cli_idcliente int,
           @cli_nombrefantasia varchar(200),
           @cli_razonsocial varchar(200),
           @cli_apynom varchar(200), 
           @cli_cativa int,
           @cli_cuit varchar(50),
           @cli_domicilio varchar(200),
           @cli_idpcia int,
           @cli_idciudad int,
           @cli_telefono varchar(200),
		   @cli_telcel varchar(200),
           @cli_email varchar(100),
           @cli_obs varchar(500),
           @cli_listaprecios int,
		   @cli_iddeposito int

AS

UPDATE [Facturacion].[dbo].[Clientes]
SET cli_nombrefantasia=@cli_nombrefantasia,
           cli_razonsocial=@cli_razonsocial,
           cli_apynom=@cli_apynom, 
           cli_cativa=@cli_cativa,
           cli_cuit=@cli_cuit,
           cli_domicilio=@cli_domicilio,
           cli_idpcia=@cli_idpcia,
           cli_idciudad=@cli_idciudad,
           cli_telefono=@cli_telefono,
           cli_email=@cli_email,
           cli_obs=@cli_obs,
           cli_listaprecios=@cli_listaprecios,
		   cli_iddeposito=@cli_iddeposito,
		   cli_telcel=@cli_telcel
     WHERE cli_idcliente=@cli_idcliente
           
           