USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ciudades_obtenerLista]    Script Date: 22/01/2015 6:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ciudades_obtenerLista]
@idProvincia int

AS

SELECT idciudad,ciudad from Ciudades WHERE idProvincia=@idprovincia