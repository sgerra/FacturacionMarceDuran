Use Facturacion
GO

ALTER PROCEDURE PagosProveedoresDetalles_insertarRegistro
@ppd_feven datetime,
@ppd_tipfac varchar(50),
@ppd_nrofac varchar(50),
@ppd_totalfac float,
@ppd_idcompra int,
@ppd_deposito varchar(50),
@ppd_feccom datetime,
@ppd_nropago int

AS

INSERT INTO PagosProveedores_Detalles
(ppd_feven,ppd_tipfac,ppd_nrofac,ppd_totalfac,ppd_idcompra,ppd_deposito,ppd_feccom,ppd_nropago)
VALUES
(@ppd_feven,@ppd_tipfac,@ppd_nrofac,@ppd_totalfac,@ppd_idcompra,@ppd_deposito,@ppd_feccom,@ppd_nropago)




