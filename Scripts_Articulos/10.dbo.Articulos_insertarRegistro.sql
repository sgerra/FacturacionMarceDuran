USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_insertarRegistro]    Script Date: 19/01/2015 13:24:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[Articulos_insertarRegistro]
	(@codart int, 
	 @desc_2 	[varchar](50),
	 @cod_3 	[varchar](50),
	 @rubro_5 	[int],
	 @costo_8 	[float],
	 @activo_13 	[char](1),
	 @signo int,
	 @idproveedor int,
	 @iduni int,
	 @idEtiqueta int,
	 @costogranel decimal(18,2),
	 @unidadesGranel decimal(18,2))
AS INSERT INTO [facturacion].[dbo].[Articulos] 
	 ([codart],
	 [desc],
	 [cod],
	 [rubro],
	 [costo],
	 [activo],
	 [signo],
	 [idproveedor],
	 [uni_id],
	 [idEtiqueta] ,
     [costogranel],
	 [unidadesgranel])
VALUES 
	(@codart,
	 @desc_2,
	 @cod_3,
	 @rubro_5,
	 @costo_8,
	 @activo_13,
	 @signo,
	 @idproveedor,
	 @iduni,
	 @idEtiqueta,
	 @costogranel,
	 @unidadesgranel)

	 set @codart  = @@identity 
	select @codart as codart