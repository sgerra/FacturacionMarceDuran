USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[t_factura_emula_obtenerRegistro]    Script Date: 22/10/2014 11:26:03 a.m. ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[t_factura_obtenerRegistro] 
@Codigo varchar (1)
AS
SELECT * FROM t_factura WHERE codigo=@Codigo
