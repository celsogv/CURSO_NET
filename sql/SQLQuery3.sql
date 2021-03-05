--1. Mostrar los nombres de los empleados ordenados alfabéticamente (Z…A)

SELECT nombre FROM trabajador
ORDER BY nombre DESC


--2. Seleccionar el nombre, el oficio y la localidad de los departamentos donde trabajan los Vendedores.

SELECT nombre, oficio, dir FROM trabajador
WHERE oficio='vendedor'


--3. Listar los nombres de los empleados cuyo nombre termine con la letra ‘o’.


SELECT nombre FROM trabajador
WHERE nombre LIKE '%o'


--4. Seleccionar el nombre, el oficio y salario de los empleados que trabajan en Salas.


SELECT nombre, oficio, salario FROM trabajador
WHERE dir='salas'

--5. Seleccionar el nombre, salario y localidad donde trabajan de los empleados que tengan un salario entre 1000 y 1300.

SELECT nombre, salario, dir FROM trabajador
WHERE salario BETWEEN 1000 AND 1300



--6. Nombre de los empleados que trabajan en Gijón y cuyo oficio sea analista o Vendedor.


SELECT nombre FROM trabajador
WHERE oficio='analista' OR oficio='vendedor'


--7. Visualizar los departamentos con más de 5 empleados.

SELECT depto_no FROM trabajador
WHERE 



--8. Mostrar el nombre, salario y nombre del departamento de los empleados que tengan el mismo oficio que ‘Leonel Alfonso Esquivel’ (subconsulta).


SELECT nombre, salario, depto_no FROM trabajador
WHERE
oficio = (SELECT oficio FROM trabajador
WHERE nombre='esquivel leonel alfonso')


--9. Mostrar los datos de los empleados que trabajan en el departamento de contabilidad,

SELECT * FROM trabajador
WHERE depto_no = (SELECT depto_no FROM departamento
WHERE nombre_dpto='contabilidad')


--10. Calcula el salario medio de todos los empleados.


SELECT nombre='promedio', AVG(salario) salario_medio
FROM trabajador


--11. ¿Cuál es el máximo salario de los empleados del departamento 10?

SELECT MAX(salario)
FROM trabajador
WHERE depto_no = '10'

--12. Mostrar el nombre, salario y nombre del departamento de los empleados 
--que tengan el mismo oficio que “Castillo Montes Luis” y que no tengan comisión (subconsulta).


SELECT nombre, salario, depto_no from trabajador
WHERE oficio != (SELECT oficio FROM trabajador
WHERE nombre='castillo montes luis' AND comision='0')

--13. Calcula el salario mínimo de los empleados del departamento ‘VENTAS’.


SELECT MIN(salario) FROM trabajador
WHERE depto_no ='ventas'