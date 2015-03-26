use facturacion

go

CREATE PROCEDURE [dbo].[Listapreciosdet_eliminarRegistro]
@lpd_lpr_id int,
@lpd_art_codart int

AS

DELETE FROM Listaprecios_det
WHERE [lpd_lpr_id]=@lpd_lpr_id and [lpd_art_codart]=@lpd_art_codart