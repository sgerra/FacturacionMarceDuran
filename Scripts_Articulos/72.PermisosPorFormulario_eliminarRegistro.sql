USE FACTURACION
GO

CREATE PROCEDURE PermisosPorFormulario_eliminarRegistro
@ppf_idperfil int

AS

DELETE FROM PermisosPorFormulario WHERE ppf_idperfil=@ppf_idperfil

