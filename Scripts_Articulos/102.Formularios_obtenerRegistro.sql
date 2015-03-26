USE Facturacion

GO

CREATE PROCEDURE Formularios_obtenerRegistro
@nombreformu varchar(50)

AS

SELECT * from Formularios WHERE frm_nombre LIKE @nombreformu