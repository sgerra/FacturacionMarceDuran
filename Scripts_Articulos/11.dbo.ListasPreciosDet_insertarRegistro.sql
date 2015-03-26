USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[ListasPreciosDet_obtenerRegistro]    Script Date: 19/01/2015 13:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListasPreciosDet_insertarRegistro]
@lpd_lpr_id int,
@lpd_art_codart int,
@lpd_PrecioC float,
@lpd_porcDesc float,
@lpd_montoDesc float,
@lpd_porcpercep float,
@lpd_montopercep float,
@lpd_preciosubtotal float,
@lpd_porcUtil float,
@lpd_utilidad float,
@lpd_porcIva float, 
@lpd_MontoIva float,
@lpd_precioVta float,
@lpd_fecModipr datetime,
@lpd_idusuario int,
@lpd_modificado char(1)

AS

INSERT INTO Listaprecios_det
(lpd_lpr_id,lpd_art_codart,lpd_PrecioC,lpd_porcDesc,lpd_montoDesc,lpd_porcpercep,lpd_montopercep,lpd_preciosubtotal,lpd_porcUtil,lpd_utilidad,lpd_porcIva,lpd_MontoIva ,lpd_precioVta ,lpd_fecModipr ,lpd_idusuario,lpd_modificado)
VALUES
(@lpd_lpr_id ,@lpd_art_codart,@lpd_PrecioC ,@lpd_porcDesc,@lpd_montoDesc,@lpd_porcpercep,@lpd_montopercep,@lpd_preciosubtotal,@lpd_porcUtil,@lpd_utilidad,@lpd_porcIva,@lpd_MontoIva,@lpd_precioVta,@lpd_fecModipr,@lpd_idusuario,@lpd_modificado)
 


