
/****** Script para el comando SelectTopNRows de SSMS  ******/

CREATE PROCEDURE PermisosPorFormulario_obtenerLista
@ppf_idperfil int
AS
SELECT *  
FROM PermisosPorFormulario,ItemMenu
WHERE ppf_idformu=ItemMenu.itm_frm_id
AND ppf_idperfil=@ppf_idperfil

