--1

CREATE PROCEDURE mostrarinformacion
AS
SELECT *
FROM cursos
GO


exec mostrarinformacion


--2

CREATE PROCEDURE mostrarsocios4
AS
SELECT nombre
FROM socios
WHERE nombre LIKE 'h%'
GO

exec mostrarsocios4


--3

CREATE PROCEDURE contarcurso3
AS
SELECT count(numero)
FROM cursos
WHERE profesor LIKE 'A%'
GO


exec contarcurso3


--4

CREATE PROCEDURE valorsocios
@valornombre	