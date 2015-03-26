USE FACTURACION
GO

ALTER PROCEDURE PermisosPorFormu_insertarRegistro
@ppf_id int,
@ppf_idformu int,
@ppf_idperfil int,
@ppf_permisos varchar(50)

AS


INSERT INTO PermisosPorFormulario 
(ppf_idformu,ppf_idperfil ,ppf_permisos)
VALUES (@ppf_idformu,@ppf_idperfil ,@ppf_permisos)