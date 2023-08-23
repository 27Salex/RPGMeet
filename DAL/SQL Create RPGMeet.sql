/*
- COSAS A MEJORAR DEL SQL 

	Sacar las constraints fk fueras con un nombre 

	Crear un script que crea los valores de 
		- Localidad
		- Tema
		- Tienda
		- Juego
*/


CREATE TABLE Localidad (
	IdLocalidad int IDENTITY(1,1) PRIMARY KEY,
	NombreLocalidad VARCHAR(100) NOT NULL
);

CREATE TABLE FotoPerfil (
	IdFotoPerfil int IDENTITY(1,1) PRIMARY KEY,
	RutaArchivo VARCHAR(100) NOT NULL
);

CREATE TABLE Tema (
	IdTema int IDENTITY(1,1) PRIMARY KEY,
	NombreTema VARCHAR(100) UNIQUE NOT NULL
);


CREATE TABLE Juego (
    IdJuego int IDENTITY(1,1) PRIMARY KEY, --**
    NombreJuego VARCHAR(100) UNIQUE NOT NULL, 
	Reglas VARCHAR(1000) NOT NULL,
	MinJugadores SMALLINT,
	MaxJugadores SMALLINT NOT NULL  
);


CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Email VARCHAR UNIQUE NOT NULL,
	Pass varchar NOT NULL,
    Username varchar(30) UNIQUE NOT NULL,
	FKLocalidad int,
	FKFotoPerfil int
	--FOREIGN KEY (FKLocalidad) REFERENCES Localidad(IdLocalidad), -- ponerlas fuera 
	-- FOREIGN KEY (FKFotoPerfil) REFERENCES FotoPerfil(IdFotoPerfil)-- ponerlas fuera 
);

-- CONSTRAINT 
 ALTER TABLE Usuario 
 ADD CONSTRAINT FkUsuarioLocalidad FOREIGN KEY (FKLocalidad) REFERENCES Localidad(IdLocalidad);
 
 ALTER TABLE Usuario 
 ADD CONSTRAINT FkUsuarioFotoPerfil FOREIGN KEY (FKFotoPerfil) REFERENCES FotoPerfil(IdFotoPerfil);
	

CREATE TABLE Historia (
	IdHistoria INT IDENTITY(1,1) PRIMARY KEY,
	Titulo VARCHAR(100) NOT NULL,
	Sinopsis VARCHAR(50), 
	Contenido TEXT NOT NULL,
	EsPersonaje BIT NOT NULL, -- PARA CUANDO LAS HISTORIAS TENGAN INFORMACION DE PERSONAJES (IDEA FUTURA ES MEJOR CREAR UNA TABLA Y BORRAR ESTE ATRIBUTO LUEGO )
	FKEscritor INT
	-- FOREIGN KEY (FKEscritor) REFERENCES Usuario(IdUsuario)
);

-- CONSTRAINT
ALTER TABLE Historia 
ADD CONSTRAINT FkHistoriaUsuario FOREIGN KEY (FKEscritor) REFERENCES Usuario(IdUsuario);


CREATE TABLE Tienda (
	IdTienda INT IDENTITY(1,1) PRIMARY KEY,
	NombreTienda VARCHAR(50) NOT NULL,
	Direccion VARCHAR NOT NULL,
	Descripcion VARCHAR NOT NULL,
	HoraApertura TIME,
	HoraCierre TIME,
	CodigoPostal INT NOT NULL,
	Web VARCHAR(100),
	Telefono INT,
	ImgUrl VARCHAR(1000) NOT NULL,
	FKLocalidad INT,
	FOREIGN KEY (FKLocalidad) REFERENCES Localidad(IdLocalidad)
);
-- CONSTRAINT
ALTER TABLE Usuario 
ADD CONSTRAINT FkTiendaLocalidad FOREIGN KEY (FKLocalidad) REFERENCES Localidad(IdLocalidad);

CREATE TABLE Grupo (
	IdGrupo INT IDENTITY(1,1) PRIMARY KEY,
	TituloParitda VARCHAR (50) NOT NULL,
	Descripcion VARCHAR (255) ,
	-- EstadoGrupo SMALLINT NOT NULL, -- FINALIZADA -1  BUSCANDO 0 FINALIZADA -1
	MaxJugadores SMALLINT NOT NULL,
	-- EsOnline BIT DEFAULT 0 NOT NULL,
	QuedarLunes BIT DEFAULT 0 NOT NULL,		
    QuedarMartes BIT DEFAULT 0 NOT NULL, 
    QuedarMiercoles BIT DEFAULT 0 NOT NULL, 
    QuedarJueves BIT DEFAULT 0 NOT NULL,	
    QuedarViernes BIT DEFAULT 0 NOT NULL, 
    QuedarSabado BIT DEFAULT 0 NOT NULL, 
    QuedarDomingo BIT DEFAULT 0 NOT NULL,
	FKGameMaster INT NOT NULL,
	FKTemaPrincipal INT NOT NULL,
	FKTemaSecundario INT,
	FKJuego INT NOT NULL,

	FOREIGN KEY (FKGameMaster) REFERENCES Usuario(IdUsuario),
	FOREIGN KEY (FKTemaPrincipal) REFERENCES Tema(IdTema),
	FOREIGN KEY (FKTemaSecundario) REFERENCES Tema(IdTema),
	FOREIGN KEY (FKJuego) REFERENCES Juego(IdJuego)
);


CREATE TABLE UsuarioGrupo (
	IdUsuarioPartida INT IDENTITY(1,1) PRIMARY KEY,
	FKUsuario INT,
	FKGrupo INT,
	FOREIGN KEY (FKUsuario) REFERENCES Usuario(IdUsuario),
	FOREIGN KEY (FKGrupo) REFERENCES Grupo(IdGrupo),
);

CREATE TABLE Sesion (
	IdSesion INT IDENTITY(1,1) PRIMARY KEY,
	Resumen TEXT,
	Dia DATE NOT NULL,
	Hora TIME,
	EsOnline BIT NOT NULL,
	FKGrupo INT,
	FKTienda INT,
	FOREIGN KEY (FKGrupo) REFERENCES Grupo(idGrupo),
	FOREIGN KEY (FKTienda) REFERENCES Tienda(idTienda)
);

