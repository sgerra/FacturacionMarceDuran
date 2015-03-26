select * from articulos where [desc] like '%COCA%'

select * from Proveedores where idProveedor=24

UPDATE Articulos 
set unidadesgranel=8, costogranel=74.56,uni_id=3 
where codart in (595,596,593)