USE FACTURACION

GO

CREATE PROCEDURE tFactura_actualizarRegistro
@codigo varchar(1)

AS

UPDATE t_factura
set ultimo=ultimo+1
WHERE codigo=@codigo