/****** Script para el comando SelectTopNRows de SSMS  ******/
USE FActuracion
GO

ALTER PROCEDURE Articulos_ArmarNovedades

AS

Select codart,[desc],cod,lpd_precioVta as Precio,lpd_lpr_id as IdLista from Articulos art, Listaprecios_det ld
where art.codart=ld.lpd_art_codart AND
      art.activo='S'