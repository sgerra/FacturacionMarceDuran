USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[OtrosConceptos_obtenerLista]    Script Date: 10/12/2014 6:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[OtrosConceptos_obtenerLista]
@nropago int

AS

SELECT *
From Pagos_OtrosConceptos
Where poc_nropago =@nropago
                 
				 