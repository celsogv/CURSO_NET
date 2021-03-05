--4

SELECT COUNT(nombre)
FROM empleados


--5

SELECT * FROM empleados WHERE fechaingreso 


--6

SELECT COUNT(sueldo)
FROM empleados


--7

SELECT COUNT(nombre)
FROM empleados
WHERE seccion='Secretaria'


--8 



SELECT MAX(sueldo) AS valorsueldo
FROM empleados; 

SELECT MIN(sueldo) AS valorsueldo
FROM empleados; 


--9

SELECT MAX(cantidadhijos)
FROM empleados
WHERE nombre LIKE '%Perez'



--10


SELECT MAX(fechaingreso)
FROM empleados; 



SELECT MIN(fechaingreso)
FROM empleados; 



--11


SELECT MIN(documento)
FROM empleados; 



--12


SELECT AVG(sueldo)
FROM empleados; 


--13

SELECT AVG(sueldo)
FROM empleados
WHERE seccion='Secretaria'

--14


SELECT AVG(cantidadhijos)
FROM empleados
WHERE seccion='Sistemas'



