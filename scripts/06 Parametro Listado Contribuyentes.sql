SELECT *
FROM ParametroDet
WHERE parame_codigo = 440
WHERE pardet_Descripcion like '%sucur%'

SELECT * FROM TipoMovimientoInventario
DELETE FROM TipoMovimientoInventario Where Pardet_TipoMovInv<7
DELETE FROM TipoMovimientoInventario Where Pardet_TipoMovInv>7
DELETE FROM Parametrodet WHERE Parame_codigo = 440 and Pardet_secuencia < 6
DELETE FROM Parametrodet WHERE Parame_codigo = 440 and Pardet_secuencia between 8 and 20 

SELECT *
from parametro 
WHERE parame_descripcion like '%Mov%'

update ParametroDet 
set pardet_Descripcion = 'Zona' 
where parame_codigo = 5 and pardet_Secuencia = 111

INSERT INTO ParametroDet 
VALUES (5,120,'Listado de Contribuyentes','',NULL,NULL,0,1,4,100,NULL,'Muestra el listado de contribuyentes',NULL,NULL,NULL,NULL)

exec proc_restriccion 'u',null, null, null, 1,1,1,1,1,1