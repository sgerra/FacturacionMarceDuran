USE FACTURACION
GO

CREATE PROCEDURE Perfiles_insertarRegistro
@prf_id int,
@prf_detperfil varchar(50)


AS

INSERT INTO Perfiles
(prf_detperfil)
VALUES
(@prf_detperfil)