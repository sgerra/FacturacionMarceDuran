USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[CajaDiaria_SeleccionarCajas]    Script Date: 28/01/2015 21:51:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE [dbo].[CajasDiarias_obtenerDetalle]
@nroCaja int
AS

SELECT * FROM CajaDiaria cd,usuarios u 
WHERE cd.caj_idusuario=u.usu_id and caj_id=@nroCaja
order by caj_id
