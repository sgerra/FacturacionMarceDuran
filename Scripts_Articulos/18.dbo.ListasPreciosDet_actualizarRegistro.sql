USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ListaPreciosDet_actualizarRegistro]    Script Date: 19/01/2015 20:15:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListasPreciosDet_actualizarRegistro]
@lpd_lpr_id int,
@lpd_art_codart int,
@lpd_PrecioC float,
@lpd_porcDesc float,
@lpd_montoDesc float,
@lpd_porcPercep float,
@lpd_montoPercep float,
@lpd_PrecioSubTotal float,
@lpd_porcutil float,
@lpd_utilidad float,
@lpd_porciva float,
@lpd_Montoiva float,
@lpd_precioVta float,
@lpd_fecmodipr datetime,
@lpd_idusuario int,
@lpd_modificado char(1)

AS

if not exists (Select * from Listaprecios_det where lpd_lpr_id=@lpd_lpr_id and lpd_art_codart=@lpd_art_codart)
BEGIN
	INSERT INTO Listaprecios_det
	(lpd_lpr_id,lpd_art_codart,lpd_PrecioC,lpd_porcdesc,lpd_montodesc,lpd_porcPercep,lpd_montoPercep,lpd_PrecioSubtotal,lpd_porcutil,lpd_utilidad,lpd_porciva,lpd_Montoiva,lpd_precioVta,lpd_fecmodipr,lpd_idusuario,lpd_modificado)

	VALUES
	(@lpd_lpr_id,@lpd_art_codart,@lpd_PrecioC,@lpd_porcdesc,@lpd_montodesc,@lpd_porcPercep,@lpd_montoPercep,@lpd_PrecioSubtotal,@lpd_porcutil,@lpd_utilidad,@lpd_porciva,@lpd_Montoiva,@lpd_precioVta,@lpd_fecmodipr,@lpd_idusuario,@lpd_modificado)
END

ELSE

BEGIN
	UPDATE Listaprecios_det
	SET  lpd_PrecioC=@lpd_PrecioC,
	     lpd_porcdesc=@lpd_porcdesc,
	     lpd_montodesc=@lpd_montoDesc,
	     lpd_porcPercep=@lpd_porcPercep,
	     lpd_montoPercep=@lpd_montoPercep,
	     lpd_PrecioSubtotal=@lpd_PrecioSubTotal,
		 lpd_porcutil=@lpd_porcutil,
		 lpd_utilidad=@lpd_utilidad,
		 lpd_porciva=@lpd_porciva,
		 lpd_Montoiva=@lpd_Montoiva,
		 lpd_precioVta=@lpd_precioVta,
		 lpd_fecmodipr=@lpd_fecmodipr,
		 lpd_idusuario=@lpd_idusuario,
		 lpd_modificado=@lpd_modificado


	WHERE lpd_art_codart=@lpd_art_codart and lpd_lpr_id=@lpd_lpr_id 

END	