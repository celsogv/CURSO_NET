SELECT *
FROM Doctor




-- Procedimientos para doctores.


CREATE PROCEDURE insertardoctor
@codigohospital int,
@numerodoctor int,
@nombredoctor varchar(50),
@especialidad varchar(50)
AS
INSERT INTO Doctor (Hospital_Cod, Doctor_No, Apellido, Especialidad)
VALUES(@codigohospital, @numerodoctor, @nombredoctor, @especialidad)
GO

EXEC insertardoctor 22, 129, 'aaaa', 'bbbb';




CREATE PROCEDURE modificardoctor
@codigohospital int,
@numerodoctor int,
@nombredoctor varchar(50),
@especialidad varchar(50)
AS
UPDATE Doctor
SET Hospital_Cod = @codigohospital, Doctor_No = @numerodoctor, Apellido = @nombredoctor, Especialidad = @especialidad
WHERE Doctor_No = @numerodoctor

EXEC modificardoctor 7, 22, 'bbbb', 'bbbb';



CREATE PROCEDURE eliminardoctor
@numerodoctor int
AS
DELETE FROM Doctor WHERE @numerodoctor = Doctor_No


EXEC eliminardoctor 129;



CREATE PROCEDURE buscardoctor
@numerodoctor int
AS
SELECT * FROM Doctor WHERE @numerodoctor = Doctor_No



EXEC buscardoctor 386;

CREATE PROCEDURE listardoctores
AS
SELECT * FROM Doctor

EXEC listardoctores;



--Procedimientor para salas.



SELECT * FROM Sala


CREATE PROCEDURE insertarsala
@codigosala int,
@codigohospital int,
@nombresala varchar(50),
@especialidadsala varchar(50)
AS
INSERT INTO Sala (Sala_Cod, Cod_Hospital, Nombre, Especialidad)
VALUES (@codigosala, @codigohospital, @nombresala, @especialidadsala)
GO


EXEC insertarsala 3, 22, 'aaa', 'aaa';






CREATE PROCEDURE modificarsala2
@codigosala int,
@codigohospital int,
@nombresala varchar(50),
@especialidadsala varchar(50)
AS
UPDATE Sala
SET Sala_Cod = @codigosala, Cod_Hospital = @codigohospital, Nombre = @nombresala, Especialidad = @especialidadsala
WHERE Sala_Cod = @codigosala



EXEC modificarsala2 4, 22, 'aaaa', 'aaaa';



CREATE PROCEDURE eliminarsala
@codigosala int
AS
DELETE FROM Sala WHERE @codigosala = Sala_Cod



CREATE PROCEDURE buscarsala
@codigosala int
AS
SELECT * FROM Sala WHERE Sala_Cod = @codigosala


EXEC buscarsala 3;



CREATE PROCEDURE listarsalas
AS
SELECT * FROM Sala


EXEC listarsalas;









