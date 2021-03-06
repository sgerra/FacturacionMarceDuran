USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[precios_ActualizaciondePreciosPorArticulo]    Script Date: 21/11/2014 08:21:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[precios_ActualizaciondePreciosPorArticulo]
@codart int,
@preciocosto decimal(18,2)


AS

--------------Actualizo el precio de costo en Articulos y en Listas de precios-----------------
begin tran
update articulos
set costo=@preciocosto
where  codart= @codart 

update Listaprecios_det
set lpd_precioC=@preciocosto
where lpd_art_codart= @codart 
commit tran
------------------------------------------------------------------------
--Actualizo el monto de iva-	pcosto * porciva	---
begin tran
update dbo.Listaprecios_det 
set lpd_Montoiva=round(@preciocosto * (lpd_porciva/100),2)
where lpd_art_codart=@codart 
commit tran    

begin tran
update dbo.Listaprecios_det 
set lpd_montodesc=round((@preciocosto+lpd_Montoiva) * (lpd_porcdesc/100),2)
where lpd_art_codart=@codart 
commit tran    	

begin tran
update dbo.Listaprecios_det 
set lpd_montopercep=round((@preciocosto+lpd_Montoiva-lpd_montodesc) * (lpd_porcpercep/100),2)
where lpd_art_codart=@codart 
commit tran    	

begin tran
update dbo.Listaprecios_det 
set lpd_precioSubTotal=round((@preciocosto+lpd_Montoiva-lpd_montodesc) + lpd_montopercep,2)
where lpd_art_codart=@codart 
commit tran    		
	
begin tran
update dbo.Listaprecios_det 
set lpd_utilidad=round((lpd_precioSubTotal * (lpd_porcUtil/100)),2)
where lpd_art_codart=@codart 
commit tran    		

begin tran
update dbo.Listaprecios_det 
set lpd_precioVta=round((lpd_precioSubTotal + lpd_utilidad),2),lpd_fecmodipr=getdate(),lpd_modificado='S'
where lpd_art_codart=@codart 
commit tran    			
	
	
	



-----------------------------------------------

