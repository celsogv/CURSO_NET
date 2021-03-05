--6

CREATE VIEW vista_cursos AS
SELECT numero, deporte, dia
FROM cursos


--7


SELECT *
FROM vista_cursos
ORDER BY deporte


--8

INSERT INTO vista_cursos
VALUES(8, 'ciclismo', 'jueves', 'pedro menendez')

