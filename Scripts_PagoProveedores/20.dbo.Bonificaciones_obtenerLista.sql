USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Bonificaciones_obtenerLista]    Script Date: 11/12/2014 15:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Bonificaciones_obtenerLista]


AS

SELECT *
From bonificaciones

            