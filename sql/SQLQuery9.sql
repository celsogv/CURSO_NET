CREATE PROCEDURE insertarenfermo
@nombre varchar(50),
@inscripcion int,
@sexo varchar(2),
@fecha varchar(50),
@direccion varchar(50),
@numero int
AS
INSERT INTO Enfermo(inscripcion, Apellido, Direccion, Dir, Fecha_nac, S, NSS, Cod_Hospital)
VALUES (@inscripcion, @nombre, @direccion, NULL, @fecha, @sexo, @numero, null)
GO

EXEC insertarenfermo 'aaaa' , 1349,  'M', '20210101', 'aaaa', 2651789;





CREATE PROCEDURE modificarenfermo
@nombre varchar(50),
@inscripcion int,
@sexo varchar(2),
@fecha varchar(50),
@direccion varchar(50),
@numero int
AS
UPDATE Enfermo
SET inscripcion=@inscripcion, Apellido = @nombre, Direccion = @direccion, Dir = NULL, Fecha_Nac = @fecha, S = @sexo, NSS = @numero, Cod_Hospital = NULL
WHERE inscripcion = @inscripcion

EXEC modificarenfermo 'bbbb', 21345, 'M', '20210101', 'aaaa', '12422';


CREATE PROCEDURE eliminarenfermo
@inscripcion int
AS
DELETE FROM Enfermo WHERE @inscripcion = inscripcion


EXEC eliminarenfermo 2344321
EXEC eliminarenfermo 12344

CREATE PROCEDURE buscarenfermo
@inscripcion int
AS
SELECT * FROM Enfermo WHERE inscripcion = @inscripcion


EXEC buscarenfermo '10995'



CREATE PROCEDURE listartodos
AS
SELECt * FROM Enfermo


EXEC listartodos;



CREATE TRIGGER TR_SEGURIDAD
ON
DATABASE FOR DROP_TABLE, ALTER_TABLE
AS
BEGIN
RAISERROR
('No está permitido borrar ni modificar
tablas!' 16, 1)
ROLLBACK
TRANSACTION
END



CREATE TRIGGER BORRARSALA
ON SALA
FOR DELETE
AS
BEGIN
DELETE FROM PLANTILLA FROM SALA, DELETED
WHERE SALA.SALA_COD = DELETED.SALA_COD;
SELECT * FROM DELETED;
END



--COMPROBAR

DELETE FROM SALA WHERE SALA_COD = 1





CREATE TRIGGER MODIFICARSALA
ON SALA
FOR UPDATE
AS
UPDATE PLANTILLA
SET SALA_COD = INSERTED.SALA_COD
FROM PLANTILLA, INSERTED, DELETED
WHERE PLANTILLA.SALA_COD = DELETED.SALA_COD
SELECT * FROM INSERTED


UPDATE SALA SET SALA_COD= 8 WHERE SALA_COD = 2







CREATE TABLE Control_BD
(
EMP_NO INT NULL,
USUARIO VARCHAR(20) NULL,
FECHA DATETIME NULL,
OPERACION VARCHAR(15) NULL
)
GO



CREATE TRIGGER DAR_ALTA
ON EMP
FOR INSERT
AS
INSERT INTO Control_BD (EMP_NO, USUARIO, FECHA, OPERACION)
SELECT INSERTED.EMP_NO, USER_NAME(), GETDATE(), 'INSERCION'
FROM INSERTED




