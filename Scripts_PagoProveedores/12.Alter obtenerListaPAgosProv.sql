USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[PagosProveedores_obtenerLista]    Script Date: 08/12/2014 22:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PagosProveedores_obtenerLista]
@idprov integer


AS

SELECT *
From PagosProveedores
Where ppr_codprov = @idprov
ORDER BY ppr_nropago
