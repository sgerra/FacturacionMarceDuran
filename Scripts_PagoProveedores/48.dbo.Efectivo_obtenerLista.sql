USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Efectivo_obtenerLista]    Script Date: 09/01/2015 9:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Efectivo_obtenerLista]
--declare
@tpo_moneda int
AS
--set @tpo_moneda=1
SELECT *FROM Efectivo
WHERE pde_tpomoneda=@tpo_moneda 

