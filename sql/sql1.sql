--Lista el nombre de todos los productos que hay en la tabla producto.

SELECT nombre
FROM producto


--Lista los nombres y los precios de todos los productos de la tabla producto.

SELECT nombre, precio
FROM producto

--Lista todas las columnas de la tabla producto.

SELECT *
FROM producto

--Lista el nombre de los productos, el precio en euros y el precio en d�lares estadounidenses (USD).

SELECT nombre, precio
FROM producto





--Lista el nombre de los productos, el precio en euros y el precio en d�lares estadounidenses (USD). Utiliza los siguientes alias para las columnas: nombre de producto, euros, d�lares.


--Lista los nombres y los precios de todos los productos de la tabla producto, convirtiendo los nombres a may�scula. SELECT UPPER(campo)
SELECT UPPER(nombre)
FROM producto



--Lista los nombres y los precios de todos los productos de la tabla producto, convirtiendo los nombres a min�scula. SELECT LOWER(campo)
SELECT LOWER(nombre)
FROM producto


--Lista los nombres y los precios de todos los productos de la tabla producto, redondeando el valor del precio. ROUND(campo, 3)



SELECT nombre, ROUND(precio, 3)
FROM producto


--Lista el c�digo de los proveedor que tienen productos en la tabla producto.


SELECT codigo_fabricante
FROM producto




--Lista el c�digo de los proveedor que tienen productos en la tabla producto, eliminando los c�digos que aparecen repetidos.

SELECT DISTINCT codigo_fabricante
FROM producto




--Lista los nombres de los proveedor ordenados de forma ascendente.


SELECT nombre
FROM proveedor 
ORDER BY nombre ASC



--Lista los nombres de los proveedor ordenados de forma descendente.

SELECT nombre
FROM proveedor 
ORDER BY nombre DESC




--Lista los nombres de los productos ordenados en primer lugar por el nombre de forma ascendente y en segundo lugar por el precio de forma descendente.

SELECT nombre, precio
FROM proveedor 
ORDER BY nombre ASC precio DESC

--Devuelve una lista con las 5 primeras filas de la tabla fabricante. SELECT TOP 3 Campo FROM Tabla;

SELECT TOP 5 nombre
FROM proveedor;


--Lista el nombre y el precio del producto m�s barato. (Funci�n MAX)





--Lista el nombre y el precio del producto m�s caro. (Funci�n MIN)



--Lista el nombre de todos los productos del fabricante cuyo c�digo de fabricante es igual a 2.




--Lista el nombre de los productos que tienen un precio menor o igual a 120�.



--Lista el nombre de los productos que tienen un precio mayor o igual a 400�.



--Lista el nombre de los productos que no tienen un precio mayor o igual a 400�.



--Lista todos los productos que tengan un precio entre 80� y 300�. Sin utilizar el operador BETWEEN.



--Lista todos los productos que tengan un precio entre 60� y 200�. Utilizando el operador BETWEEN.


--Lista todos los productos que tengan un precio mayor que 200� y que el c�digo de fabricante sea igual a 6.


--Lista el nombre y el precio de los productos en c�ntimos (Habr� que multiplicar por 100 el valor del precio). Cree un alias para la columna que contiene el precio que se llame c�ntimos.


--Lista los nombres de los proveedor cuyo nombre empiece por la letra S.


--Lista los nombres de los proveedor cuyo nombre termine por la vocal e.



--Lista los nombres de los proveedor cuyo nombre contenga el car�cter w.


--Devuelve una lista con el nombre de todos los productos que contienen la cadena Port�til en el nombre.



--Devuelve una lista con el nombre de todos los productos que contienen la cadena Monitor en el nombre y tienen un precio inferior a 215 �.



--�Cuantos productos tenemos? (Funci�n Count)


--�Cual es el total de las cantidades de producto? (Funci�n SUM)








--�Cu�l es el promedio de las cantidaes de los productos? (Funci�n AVG)



--Lista el nombre y el precio de todos los productos que tengan un precio mayor o igual a 180�. Ordene el resultado en primer lugar por el precio (en orden descendente) y en segundo lugar por el nombre (en orden ascendente).






