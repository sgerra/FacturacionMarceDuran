USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Bonificaciones_eliminarLista]    Script Date: 09/01/2015 22:55:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Bonificaciones_eliminarRegistro]
@bon_nroprove int,
@bon_nropago int

AS

DELETE FROM Bonificaciones
WHERE bon_nroprove=@bon_nroprove and bon_nropago=@bon_nropago

