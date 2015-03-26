/****** Script para el comando SelectTopNRows de SSMS  ******/
USE FActuracion
GO

CREATE PROCEDURE Articulos_ArmarNovedades

AS

Select codart,[desc],cod,lpd_precioVta,lpd_lpr_id from Articulos art, Listaprecios_det ld
where art.codart=ld.lpd_art_codart AND
      art.activo='S'