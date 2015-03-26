-----Copio la lista 2 a la tabla auxiliar---
--insert into Listaprecios_det_AUX
--select * from Listaprecios_det where lpd_lpr_id=2

--Copio a AUX los elementos de la lista 1 que no estan en la lista 2
---------------------------------------------------------
--insert into Listaprecios_det_aux
--select * from Listaprecios_det where lpd_lpr_id=1 and lpd_art_codart not in (select lpd_art_codart from Listaprecios_det_aux)

----------elimino los de la lista 2 para no pisarlos
--delete from Listaprecios_det_aux where lpd_lpr_id=2

---------Actualizo el indice de la lista de precios
--update listaprecios_det_aux
--set lpd_lpr_id=2
-------------------Actualizo el porcentaje de ganancia a la lista correspondiente (2-12% / 3-18%)
--UPDATE Listaprecios_det_aux
--SET lpd_porcUtil=12
--where lpd_lpr_id=2

--update Listaprecios_det_aux
--set lpd_utilidad=round(lpd_preciosubtotal * (lpd_porcUtil/100),2)
--where lpd_lpr_id=2


--update Listaprecios_det_aux
--set lpd_precioVta=round((lpd_preciosubtotal+ lpd_utilidad),2)
--where lpd_lpr_id=2

--------------- copio de aux a la tabla de listas de precios con indice 2
--insert into Listaprecios_det
--select * from Listaprecios_det_aux

select * from Listaprecios_det where lpd_lpr_id=2






