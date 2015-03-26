USe facturacion
Go

CREATE PROCEDURE Ultimos_obtenerRegistro
@campo varchar(50)

AS

SELECT * FROM Ultimos 
WHERE campo like @campo

