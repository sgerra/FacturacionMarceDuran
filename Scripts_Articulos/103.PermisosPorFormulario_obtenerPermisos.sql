USE Facturacion

Go


CREATE PROCEDURE PermisosPorFormulario_obtenerPermisos
@idFormu int,
@idPerfil int

AS

Select * FROM PermisosPorFormulario 
WHERE ppf_idformu=@idFormu  AND ppf_idperfil=@idperfil