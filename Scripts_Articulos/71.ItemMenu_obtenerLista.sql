
/****** Script para el comando SelectTopNRows de SSMS  ******/

ALTER PROCEDURE ItemMenu_obtenerLista
AS

select itm_idtem,itm_checkmenu,itm_frm_id,itm_men_id from ItemMenu
