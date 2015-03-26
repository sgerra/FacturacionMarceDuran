USe facturacion
Go

CREATE PROCEDURE Ultimos_actualizarRegistro
@campo varchar(50)

AS

UPDATE Ultimos 
SET ultimo=ultimo+1
WHERE campo like @campo

