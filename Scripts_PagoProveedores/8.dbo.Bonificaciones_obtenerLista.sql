USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Bonificaciones_obtenerLista]    Script Date: 03/12/2014 13:42:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Bonificaciones_obtenerLista]


AS

SELECT bon_nrobon, bon_concepto, bon_monto, bon_NroPago, bon_usada,bon_fecha,bon_comprobante,bon_nroprove
From bonificaciones

            