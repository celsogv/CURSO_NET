CREATE TABLE PUB(
cod_pub int,
nombre nvarchar(20) NOT NULL, 
licencia_fiscal nvarchar(20) NOT NULL,
domicilio nvarchar(20), 
fecha_apertura date NOT NULL, 
horario nvarchar(20) NOT NULL, 
cod_localidad int NOT NULL
CONSTRAINT PK_pub PRIMARY KEY (cod_pub)
)


CREATE TABLE LOCALIDAD(
cod_localidad int,
nombre nvarchar(20) NOT NULL
CONSTRAINT PK_localidad PRIMARY KEY (cod_localidad)
)



--aler tablew FK
ALTER TABLE LOCALIDAD ADD CONSTRAINT fk_localidad FOREIGN KEY (cod_localidad) REFERENCES PUB(cod_localidad);


CREATE TABLE TITULAR(
dni_titular int,
nombre nvarchar(20) NOT NULL, 
domicilio nvarchar(20),
cod_pub nvarchar(20)
CONSTRAINT PK_titular PRIMARY KEY (dni_titular)
)


CREATE TABLE EMPLEADO(
dni_empleado int,
nombre nvarchar(20) NOT NULL,domicilio nvarchar(20)
CONSTRAINT PK_empleado PRIMARY KEY (dni_empleado)
)


CREATE TABLE EXISTENCIAS(
cod_articulo int,
nombre nvarchar(20) NOT NULL, cantidad nvarchar(20) NOT NULL, precio int NOT NULL, cod_pub nvarchar(20) NOT NULL
CONSTRAINT PK_existencias PRIMARY KEY (cod_articulo)
)




CREATE TABLE PUB_EMPLEADO(
cod_pub int,
dni_empleado int NOT NULL, 
funcion nvarchar(20) NOT NULL
CONSTRAINT PK_pub_empleado PRIMARY KEY (cod_pub,dni_empleado,funcion), 
CONSTRAINT FK_pub_empleado FOREIGN KEY (dni_empleado) REFERENCES empleado (dni_empleado)
)

