USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_actualizarRegistro]    Script Date: 19/01/2015 19:30:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[Articulos_actualizarRegistro]
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
	 @unidadesGranel decimal(18,2))
AS 
UPDATE [dbo].[Articulos] 
SET [desc]=@desc, [cod]=@cod,	 [rubro]=@rubro, [costo]=@costo,[activo]=@activo, [signo]=@signo,[idproveedor]=@idproveedor, [uni_id]=@uni_id, [idEtiqueta]=@idEtiqueta ,   [costogranel]=@costogranel, [unidadesgranel]=@unidadesGranel
WHERE	codart=@codart