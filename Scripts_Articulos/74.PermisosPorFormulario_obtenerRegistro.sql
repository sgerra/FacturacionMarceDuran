USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[PermisosPorFormulario_obtenerRegistro]    Script Date: 20/02/2015 14:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PermisosPorFormulario_obtenerRegistro]
@ppf_id int


AS

SELECT * FROM PermisosPorFormulario WHERE ppf_id=@ppf_id 

