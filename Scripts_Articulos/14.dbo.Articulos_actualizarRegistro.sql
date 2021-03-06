USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_insertarRegistro]    Script Date: 19/01/2015 15:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[Articulos_actualizarRegistro]
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
AS 
UPDATE [dbo].[Articulos] 
SET [desc]=@desc_2, [cod]=@cod_3,	 [rubro]=@rubro_5, [costo]=@costo_8,[activo]=@activo_13, [signo]=@signo,[idproveedor]=@idproveedor, [uni_id]=@iduni, [idEtiqueta]=@idEtiqueta ,   [costogranel]=@costogranel, [unidadesgranel]=@unidadesGranel
WHERE	codart=@codart