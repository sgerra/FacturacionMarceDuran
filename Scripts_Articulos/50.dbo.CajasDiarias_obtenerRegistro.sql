USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[CajaDiaria_SeleccionarCajas]    Script Date: 28/01/2015 21:51:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER  PROCEDURE [dbo].[CajasDiarias_obtenerRegistro]
@nroCaja int
AS

SELECT * FROM CajaDiaria cd
WHERE  caj_id=@nroCaja
order by caj_id
