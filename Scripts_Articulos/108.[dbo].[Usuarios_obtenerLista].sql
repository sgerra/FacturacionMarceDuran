USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Usuarios_obtenerLista]    Script Date: 04/03/2015 14:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Usuarios_obtenerLista]
@idSucursal int
AS

SELECT * FROM Usuarios where usu_idsucursal=@idSucursal