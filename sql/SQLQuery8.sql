CREATE PROCEDURE insertarCliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@Telefono varchar(50)
AS
INSERT INTO clientes (Nombre,Apellido1,Apellido2,Telefono)
VALUES(@Nombre, @Apellido1, @Apellido2, @Telefono)
GO


EXEC insertarCliente 'PEPE', 'PEREZ', 'PERNIA', '443223343';



CREATE PROCEDURE Modificarcliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@Telefono varchar(50)
AS
UPDATE clientes
SET Nombre=@Nombre, Apellido1=@Apellido1, Apellido2=@Apellido2, Telefono=@Telefono
WHERE Nombre=@Nombre


EXEC Modificarcliente 'GANDALF', 'EL', 'GRIS', 'XXXXXX';


CREATE PROCEDURE EliminarCliente
@Nombre varchar(50)
AS
DELETE FROM clientes WHERE @Nombre=Nombre

EXEC EliminarCliente 'GANDALF'


CREATE PROCEDURE buscarcliente
@Nombre varchar(50)
AS
SELECT * FROM clientes WHERE Nombre LIKE '%'+@Nombre+'%'



EXEC buscarcliente 'SARUMAN';





CREATE PROCEDURE listartodos
AS
SELECT * FROM clientes

EXEC listartodos;
