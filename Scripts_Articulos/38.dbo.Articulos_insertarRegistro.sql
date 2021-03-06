USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_insertarRegistro]    Script Date: 24/01/2015 10:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[Articulos_insertarRegistro]
	(@codart int, 
	 @desc 	[varchar](50),
	 @cod 	[varchar](50),
	 @rubro 	[int],
	 @costo 	[float],
	 @activo 	[char](1),
	 @signo int,
	 @idproveedor int,
	 @uni_id int,
	 @idEtiqueta int,
	 @costogranel decimal(18,2),
	 @unidadesGranel decimal(18,2),
	 @imagen image)
AS INSERT INTO [facturacion].[dbo].[Articulos] 
	 ([desc],
	 [cod],
	 [rubro],
	 [costo],
	 [activo],
	 [signo],
	 [idproveedor],
	 [uni_id],
	 [idEtiqueta] ,
     [costogranel],
	 [unidadesgranel],
	 [imagen])
VALUES 
	(@desc,
	 @cod,
	 @rubro,
	 @costo,
	 @activo,
	 @signo,
	 @idproveedor,
	 @uni_id,
	 @idEtiqueta,
	 @costogranel,
	 @unidadesgranel,
	 @imagen)

	 set @codart  = @@identity 
	select @codart as codart