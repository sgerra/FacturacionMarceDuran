USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Usuarios_insertarRegistro]    Script Date: 30/01/2015 13:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuarios_eliminarRegistro]
@usu_id int

AS

DELETE FROM [dbo].[Usuarios]
WHERE usu_id=@usu_id

           