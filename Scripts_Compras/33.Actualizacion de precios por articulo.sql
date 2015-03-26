Use [Facturacion]
Go
CREATE PROCEDURE precios_ActualizaciondePreciosPorArticulo
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

------------------------------------------------------------------------
--Actualizo el monto de iva-	pcosto * porciva	---

update dbo.Listaprecios_det 
set lpd_Montoiva=round(lpd_precioC * (lpd_porciva/100),2),
    lpd_montodesc=round((lpd_precioC+lpd_Montoiva) * (lpd_porcdesc/100),2),
	lpd_montopercep=round((lpd_precioC+lpd_Montoiva-lpd_montodesc) * (lpd_porcpercep/100),2),
	lpd_precioSubTotal=round((lpd_precioC+lpd_Montoiva-lpd_montodesc) + lpd_montopercep,2),
	lpd_utilidad=round((lpd_precioSubTotal * (lpd_porcUtil/100)),2),
	lpd_precioVta=round((lpd_precioSubTotal + lpd_utilidad),2),lpd_fecmodipr=getdate(),lpd_modificado='S'

where lpd_art_codart=@codart 

-----------------------------------------------
commit tran
