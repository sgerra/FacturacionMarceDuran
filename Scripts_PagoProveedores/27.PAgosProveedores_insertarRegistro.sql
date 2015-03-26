Use Facturacion
GO

CREATE PROCEDURE PagosProveedores_insertarRegistro
@ppr_idpago int,
@ppr_fecpago datetime,
@ppr_codprov  int,
@ppr_idusuario int,
@ppr_comprobante varchar(50),
@ppr_impocheques float,
@ppr_impoefectivo float,
@ppr_impototal float,
@ppr_saldopagoant float,
@ppr_saldopagoprox float,
@ppr_bonificaciones float,
@ppr_otrosconceptos float,
@ppr_depopago float,
@ppr_estado varchar(1),
@ppr_nropago int

--set @codart=1	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.PagosProveedores 
	(ppr_fecpago ,ppr_codprov ,ppr_idusuario ,ppr_comprobante ,ppr_impocheques ,ppr_impoefectivo ,ppr_impototal ,ppr_saldopagoant ,ppr_saldopagoprox ,ppr_bonificaciones ,ppr_otrosconceptos ,ppr_depopago ,ppr_estado ,ppr_nropago)
	VALUES (@ppr_fecpago ,@ppr_codprov ,@ppr_idusuario ,@ppr_comprobante ,@ppr_impocheques ,@ppr_impoefectivo ,@ppr_impototal ,@ppr_saldopagoant ,@ppr_saldopagoprox ,@ppr_bonificaciones ,@ppr_otrosconceptos ,@ppr_depopago ,@ppr_estado ,@ppr_nropago )
	
	set @ppr_idpago  = @@identity 
	select @ppr_idpago as ppr_idpago
END

