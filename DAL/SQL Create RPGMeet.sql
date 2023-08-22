/*
- COSAS A MEJORAR DEL SQL 

	Sacar las constraints fk fueras con un nombre 

	Crear un script que crea los valores de 
		- Localidad OK
		- Tema OK
		- Tienda OK 
		- Juego OK 
*/

CREATE TABLE Localidad (
    IdLocalidad INT IDENTITY(1,1) PRIMARY KEY,
    NombreLocalidad VARCHAR(100) NOT NULL
);

CREATE TABLE FotoPerfil (
    IdFotoPerfil INT IDENTITY(1,1) PRIMARY KEY,
    RutaArchivo VARCHAR(100) NOT NULL
);

CREATE TABLE Tema (
    IdTema INT IDENTITY(1,1) PRIMARY KEY,
    NombreTema VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Juego (
    IdJuego INT IDENTITY(1,1) PRIMARY KEY,
    NombreJuego VARCHAR(100) UNIQUE NOT NULL,
    Reglas VARCHAR(1000) NOT NULL,
    MinJugadores SMALLINT,
    MaxJugadores SMALLINT NOT NULL
);

CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Email VARCHAR UNIQUE NOT NULL,
    Pass VARCHAR NOT NULL,
    Username VARCHAR(30) UNIQUE NOT NULL,
    FKLocalidad INT,
    FKFotoPerfil INT
);

CREATE TABLE Historia (
    IdHistoria INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(100) NOT NULL,
    Sinopsis VARCHAR(50),
    Contenido TEXT NOT NULL,
    EsPersonaje BIT NOT NULL,
    FKEscritor INT
);

CREATE TABLE Tienda (
    IdTienda INT IDENTITY(1,1) PRIMARY KEY,
    NombreTienda VARCHAR(50) NOT NULL,
    Direccion VARCHAR(50) NOT NULL,
    HoraApertura TIME,
    HoraCierre TIME,
    CodigoPostal INT NOT NULL,
    FKLocalidad INT,
);
/*
-- POSIBLE CAMBIO EN LA BASE DE DATOS VER COMO QUEDA LA PARTE DE CREAR TIENDA

-- La hora ya se pondra en un futuro 

!! SI SE IMPLEMENNTA HAY QUE CAMBIAR **** MODELO **** DAL 

CREATE TABLE Tienda (
    IdTienda INT IDENTITY(1,1) PRIMARY KEY,
    NombreTienda VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(50) NOT NULL,
    Direccion VARCHAR(50) NOT NULL,
    Telefono VARCHAR(13),
    Web VARCHAR(50),
    FKLocalidad INT
);

*/

CREATE TABLE Grupo (
    IdGrupo INT IDENTITY(1,1) PRIMARY KEY,
    TituloParitda VARCHAR (50) NOT NULL,
    Descripcion VARCHAR (255),
    MaxJugadores SMALLINT NOT NULL,
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
    FKJuego INT NOT NULL
);

CREATE TABLE UsuarioGrupo (
    IdUsuarioPartida INT IDENTITY(1,1) PRIMARY KEY,
    FKUsuario INT,
    FKGrupo INT
);

CREATE TABLE Sesion (
    IdSesion INT IDENTITY(1,1) PRIMARY KEY,
    Resumen TEXT,
    Dia DATE NOT NULL,
    Hora TIME,
    EsOnline BIT NOT NULL,
    FKGrupo INT,
    FKTienda INT
);

-- CONSTRAINTS

ALTER TABLE Usuario
ADD CONSTRAINT FkUsuarioLocalidad FOREIGN KEY (FKLocalidad) REFERENCES Localidad(IdLocalidad);

ALTER TABLE Usuario
ADD CONSTRAINT FkUsuarioFotoPerfil FOREIGN KEY (FKFotoPerfil) REFERENCES FotoPerfil(IdFotoPerfil);


ALTER TABLE Historia
ADD CONSTRAINT FkHistoriaUsuario FOREIGN KEY (FKEscritor) REFERENCES Usuario(IdUsuario);


ALTER TABLE Tienda
ADD CONSTRAINT FkTiendaLocalidad FOREIGN KEY (FKLocalidad) REFERENCES Localidad(IdLocalidad);


ALTER TABLE Grupo
ADD CONSTRAINT FkGrupoGameMaster FOREIGN KEY (FKGameMaster) REFERENCES Usuario(IdUsuario);

ALTER TABLE Grupo
ADD CONSTRAINT FkGrupoTemaPrincipal FOREIGN KEY (FKTemaPrincipal) REFERENCES Tema(IdTema);

ALTER TABLE Grupo
ADD CONSTRAINT FkGrupoTemaSecundario FOREIGN KEY (FKTemaSecundario) REFERENCES Tema(IdTema);

ALTER TABLE Grupo
ADD CONSTRAINT FkGrupoJuego FOREIGN KEY (FKJuego) REFERENCES Juego(IdJuego);


ALTER TABLE UsuarioGrupo
ADD CONSTRAINT FkUsuarioGrupoUsuario FOREIGN KEY (FKUsuario) REFERENCES Usuario(IdUsuario);

ALTER TABLE UsuarioGrupo
ADD CONSTRAINT FkUsuarioGrupoGrupo FOREIGN KEY (FKGrupo) REFERENCES Grupo(IdGrupo);


ALTER TABLE Sesion
ADD CONSTRAINT FkSesionGrupo FOREIGN KEY (FKGrupo) REFERENCES Grupo(IdGrupo);

ALTER TABLE Sesion
ADD CONSTRAINT FkSesionTienda FOREIGN KEY (FKTienda) REFERENCES Tienda(IdTienda);


-- Inserts Automaticos 

INSERT INTO Localidad (NombreLocalidad) VALUES ('Barcelona');
INSERT INTO Localidad (NombreLocalidad) VALUES ('L''Hospitalet de Llobregat');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Terrassa');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Badalona');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Sabadell');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Lleida');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Tarragona');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Mataró');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Santa Coloma de Gramenet');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Reus');
INSERT INTO Localidad (NombreLocalidad) VALUES ('Girona');


INSERT INTO Tema (NombreTema) VALUES ('Fantasía Medieval Clásica');
INSERT INTO Tema (NombreTema) VALUES ('Aventuras Épicas');
INSERT INTO Tema (NombreTema) VALUES ('Intriga y Misterio');
INSERT INTO Tema (NombreTema) VALUES ('Horror');
INSERT INTO Tema (NombreTema) VALUES ('Steampunk');
INSERT INTO Tema (NombreTema) VALUES ('Apocalipsis y Postapocalipsis');
INSERT INTO Tema (NombreTema) VALUES ('Viajes en el Tiempo');
INSERT INTO Tema (NombreTema) VALUES ('Mundo Subterráneo');
INSERT INTO Tema (NombreTema) VALUES ('Invasión Extraterrestre');
INSERT INTO Tema (NombreTema) VALUES ('Intrusión de Planos Paralelos');



INSERT INTO Juego (NombreJuego, Reglas, MinJugadores, MaxJugadores) 
VALUES ('Dungeon and Dragons 5e', 'Reglas de la 5ª edición de Dungeon and Dragons.', 2, 6);

INSERT INTO Juego (NombreJuego, Reglas, MinJugadores, MaxJugadores) 
VALUES ('Dungeon and Dragons 3.5e', 'Reglas de la 3.5ª edición de Dungeon and Dragons.', 2, 8);

INSERT INTO Juego (NombreJuego, Reglas, MinJugadores, MaxJugadores) 
VALUES ('Dungeon and Dragons 4e', 'Reglas de la 4ª edición de Dungeon and Dragons.', 3, 7);




-- PONER LOS ID QUE CORRESPONDAN A LAS SIGUIENTES  LOCALIDADES 

-- Generación X Barcelona: --> Barcelona.
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('Generación X Barcelona', 'Una tienda muy conocida en el mundo de los juegos de mesa y rol, ubicada en Barcelona. Han sido reconocidos por su amplia selección de juegos y su apoyo a la comunidad de jugadores.', 'Dirección de Generación X', '123-456-789', 'https://generacionx.es/', 1);

-- Dungeon Marvels: --> Barcelona 
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('Dungeon Marvels', 'Esta tienda en línea con base en Barcelona también ha organizado eventos y torneos para juegos de mesa y rol. Pueden tener opciones para participar en partidas de Dungeons & Dragons.', 'Dirección de Dungeon Marvels', '987-654-321', 'https://www.dungeonmarvels.com/', 1);

-- LaTorre de Daus: --> Barcelona 
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('LaTorre de Daus', 'Ubicada en Barcelona, esta tienda ha sido un punto de encuentro para jugadores de juegos de mesa y cartas coleccionables. Es posible que también ofrezcan actividades de rol.', 'Dirección de LaTorre de Daus', '555-123-456', 'https://latorrededauss.com/', 1);

-- JugarXJugar: --> Barcelona 
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('JugarXJugar', 'Con tiendas en varias ciudades de Cataluña, incluyendo Barcelona, JugarXJugar ha sido conocida por su variedad de juegos y eventos.', 'Dirección de JugarXJugar', '222-333-444', 'https://jugarxjugar.com/', 1);

-- Nostromo: --> Barcelona 
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('Nostromo', 'Una tienda de cómics y juegos en Barcelona que podría tener opciones para juegos de rol y eventos de Dungeons & Dragons.', 'Dirección de Nostromo', '444-555-666', 'https://www.nostromocomics.com/', 1);

-- Kaburi: -->  Girona 
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('Kaburi', 'Situada en Girona, esta tienda también podría tener actividades de juegos de rol.', 'Dirección de Kaburi', '777-888-999', 'https://kaburi.cat/', 1);

-- El Club de la Lucha: --> Tarragona
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('El Club de la Lucha', 'Ubicado en Tarragona, esta tienda se centra en juegos de mesa y cartas coleccionables, y podría tener eventos de rol.', 'Dirección de El Club de la Lucha', '111-222-333', 'https://www.elclubdelalucha.es/', 1);

-- El dado dorado: --> Lleida 
INSERT INTO Tienda (NombreTienda, Descripcion, Direccion, Telefono, Web, FKLocalidad)
VALUES ('El dado dorado', 'En Lleida, esta tienda podría ser una opción para buscar actividades de rol.', 'Dirección de El dado dorado', '555-444-333', 'https://www.eldadodorado.com/', 1);