USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[PAgosProveedores_obtenerRegistro]    Script Date: 09/01/2015 10:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PAgosProveedores_obtenerRegistro]
@ppr_idpago int

AS

SELECT * FROM PagosProveedores
WHERE ppr_nropago=@ppr_idpago
