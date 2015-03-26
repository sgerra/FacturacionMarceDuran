use facturacion
go

CREATE PROCEDURE DepositosPagos_eliminarRegistro
@dep_nropago int

AS

DELETE FROM deposito_pagos
WHERE dep_nropago=@dep_nropago

