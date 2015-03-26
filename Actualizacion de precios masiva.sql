Select * from Articulos,Listaprecios_det where codart=lpd_art_codart and idproveedor=7 and rubro=7
--Actualizo el monto de iva-	pcosto * porciva	---
begin tran
update t1
set t1.lpd_Montoiva=round(t1.lpd_precioC * (t1.lpd_porciva/100),2)
FROM dbo.Listaprecios_det AS t1
INNER JOIN dbo.Articulos AS t2
ON t1.lpd_art_codart = t2.codart
 where idproveedor=7 and rubro=7 and  t1.lpd_art_codart=t2.codart
commit tran
-----------------------------------------------
--Actualizo el monto de descuento--(pcosto +montoiva)*(porcdesc/100)	--
begin tran
update t1
set t1.lpd_montodesc=round((t1.lpd_precioC+lpd_Montoiva) * (t1.lpd_porcdesc/100),2)
FROM dbo.Listaprecios_det AS t1
INNER JOIN dbo.Articulos AS t2
ON t1.lpd_art_codart = t2.codart
 where idproveedor=7 and rubro=7 and  t1.lpd_art_codart=t2.codart
commit tran
--Caluclo el porcentaje de percepcion (Pcosto + MontoIva - MontoDesc)*(porcperce/100)
begin tran
update t1
set t1.lpd_montopercep=round((t1.lpd_precioC+lpd_Montoiva-lpd_montodesc) * (t1.lpd_porcpercep/100),2)
FROM dbo.Listaprecios_det AS t1
INNER JOIN dbo.Articulos AS t2
ON t1.lpd_art_codart = t2.codart
 where idproveedor=7 and rubro=7 and  t1.lpd_art_codart=t2.codart
commit tran
--Caluclo el Subtotal (Pcosto + MontoIva - MontoDesc)+ montopercep
begin tran
update t1
set t1.lpd_precioSubTotal=round((t1.lpd_precioC+lpd_Montoiva-lpd_montodesc) + lpd_montopercep,2)
FROM dbo.Listaprecios_det AS t1
INNER JOIN dbo.Articulos AS t2
ON t1.lpd_art_codart = t2.codart
 where idproveedor=7 and rubro=7 and  t1.lpd_art_codart=t2.codart
commit tran
--Caluclo el monto util(subtotal * porcutil/100)
begin tran
update t1
set t1.lpd_utilidad=round((t1.lpd_precioSubTotal * (t1.lpd_porcUtil/100)),2)
FROM dbo.Listaprecios_det AS t1
INNER JOIN dbo.Articulos AS t2
ON t1.lpd_art_codart = t2.codart
 where idproveedor=7 and rubro=7 and  t1.lpd_art_codart=t2.codart
commit tran
--Caluclo el precio de venta Subtotal + montoutil
begin tran
update t1
set t1.lpd_precioVta=round((t1.lpd_precioSubTotal + lpd_utilidad),2),t1.lpd_fecmodipr='11/09/2014'
FROM dbo.Listaprecios_det AS t1
INNER JOIN dbo.Articulos AS t2
ON t1.lpd_art_codart = t2.codart
 where idproveedor=7 and rubro=7 and  t1.lpd_art_codart=t2.codart
commit tran


