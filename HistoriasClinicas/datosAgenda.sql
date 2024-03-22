/*
--Crear la base de datos
CREATE DATABASE datosAgenda;

--Utilizar la base de datos creada
USE datosAgenda;

--Crear la tabla ObraSocial
CREATE TABLE ObraSocial (
    ID INT,
    Nombre VARCHAR(MAX)
);

--Crear la tabla UsuarioModel
CREATE TABLE UsuarioModel (
    ID INT,
    Nombre VARCHAR(MAX),
    Apellido VARCHAR(MAX),
    DNI INT,
    Nacimiento DATETIME,
    Sexo VARCHAR(MAX),
    Telefono VARCHAR(MAX),
    Direccion VARCHAR(MAX),
    Correo VARCHAR(MAX),
    Consulta DATETIME,
    ObraSocialFK INT
);

--Crear la tabla Medicacion
CREATE TABLE Medicacion (
    ID INT,
    Droga VARCHAR(MAX),
    Prescripcion VARCHAR(MAX),
    Receta VARCHAR(MAX),
    Fecha DATETIME,
    HistoriasClinicasFK INT
);

--Crear la tabla HistoriasClinicas
CREATE TABLE HistoriasClinicas (
    ID INT,
    Fecha DATETIME,
    MotivoVisita VARCHAR(MAX),
    Sintomas VARCHAR(MAX),
    Diagnostico VARCHAR(MAX),
    Tratamiento VARCHAR(MAX),
    UsuarioModelFK INT
);

--Crear la tabla Estudios
CREATE TABLE Estudios (
    ID INT,
    Tipo VARCHAR(MAX),
    Especificaciones VARCHAR(MAX),
    Fecha DATETIME,
    HistoriasClinicasFK INT
);

--Crear la tabla UsuarioAgenda con incremento automático del ID
CREATE TABLE UsuarioAgenda (
    ID INT IDENTITY(0, 1),
    Usuario VARCHAR(MAX),
    Contraseña VARCHAR(MAX)
);
*/

USE datosAgenda;

--Consultar los datos de la tabla ObraSocial
SELECT * FROM ObraSocial;

--Consultar los datos de la tabla UsuarioModel
SELECT * FROM UsuarioModel;

--Consultar los datos de la tabla Medicacion
SELECT * FROM Medicacion;

--Consultar los datos de la tabla HistoriasClinicas
SELECT * FROM HistoriasClinicas;

--Consultar los datos de la tabla Estudios
SELECT * FROM Estudios;

--Consultar los datos de la tabla UsuarioAgenda
SELECT * FROM UsuarioAgenda;

--Insertar un registro en la tabla UsuarioAgenda
INSERT INTO UsuarioAgenda (Usuario, Contraseña) VALUES ('usuario', 'usuario');

--Insertar un registro en la tabla ObraSocial
INSERT INTO ObraSocial (ID, Nombre) VALUES (0, 'INSSSEP');

--Insertar un registro en la tabla UsuarioModel
INSERT INTO UsuarioModel (ID, Nombre, Apellido, DNI, Nacimiento, Sexo, Telefono, Direccion, Correo, Consulta, ObraSocialFK)
VALUES (0, 'Lucas', 'Alvarez', 43787982, '20011121', 'Hombre', '3624769923', 'Pellegrini 155', 'LucasAlvarez@hotmail.com', '20230629', 0);

--Insertar un registro en la tabla Medicacion
INSERT INTO Medicacion (ID, Droga, Prescripcion, Receta, Fecha, HistoriasClinicasFK)
VALUES (0, 'Aspirina', 'Tomar 1 tableta cada 6 horas', 'Hacer reposo', '20230629', 0);

--Insertar un registro en la tabla HistoriasClinicas
INSERT INTO HistoriasClinicas (ID, Fecha, MotivoVisita, Sintomas, Diagnostico, Tratamiento, UsuarioModelFK)
VALUES (0, '20230629', 'Control rutinario', 'Ninguno', 'Saludable', 'Sin tratamiento', 0);

--Insertar un registro en la tabla Estudios
INSERT INTO Estudios (ID, Tipo, Especificaciones, Fecha, HistoriasClinicasFK)
VALUES (0, 'Radiografía', 'Tórax', '20230629', 0);

--Variable para almacenar el ID del usuario a eliminar
DECLARE @UsuarioID INT;
SET @UsuarioID = 0;

--Eliminar los registros relacionados en la tabla Medicacion
DELETE FROM Medicacion
WHERE HistoriasClinicasFK IN (
    SELECT ID
    FROM HistoriasClinicas
    WHERE UsuarioModelFK = @UsuarioID
);

--Eliminar los registros relacionados en la tabla Estudios
DELETE FROM Estudios
WHERE HistoriasClinicasFK IN (
    SELECT ID
    FROM HistoriasClinicas
    WHERE UsuarioModelFK = @UsuarioID
);

--Eliminar los registros de la tabla HistoriasClinicas para el usuario especificado
DELETE FROM HistoriasClinicas
WHERE UsuarioModelFK = @UsuarioID;

--Eliminar el registro de la tabla UsuarioModel para el usuario especificado
DELETE FROM UsuarioModel
WHERE ID = @UsuarioID;

--Eliminar el registro de la tabla ObraSocial con ID 0
DELETE FROM ObraSocial WHERE ID = 0;

--Actualizar el nombre de una obra social en la tabla ObraSocial
DECLARE @NuevoValor VARCHAR(MAX), @Atributo VARCHAR(MAX), @ID INT;
UPDATE ObraSocial SET
    Nombre = @NuevoValor
WHERE ID = @ID;

--Actualizar los atributos de un usuario en la tabla UsuarioModel
UPDATE UsuarioModel SET
    Nombre = CASE WHEN @Atributo = 'Nombre' THEN @NuevoValor ELSE Nombre END,
    Apellido = CASE WHEN @Atributo = 'Apellido' THEN @NuevoValor ELSE Apellido END,
    DNI = CASE WHEN @Atributo = 'DNI' THEN @NuevoValor ELSE DNI END,
    Nacimiento = CASE WHEN @Atributo = 'Nacimiento' THEN @NuevoValor ELSE Nacimiento END,
    Sexo = CASE WHEN @Atributo = 'Sexo' THEN @NuevoValor ELSE Sexo END,
    Telefono = CASE WHEN @Atributo = 'Telefono' THEN @NuevoValor ELSE Telefono END,
    Direccion = CASE WHEN @Atributo = 'Direccion' THEN @NuevoValor ELSE Direccion END,
    Correo = CASE WHEN @Atributo = 'Correo' THEN @NuevoValor ELSE Correo END,
    Consulta = CASE WHEN @Atributo = 'Consulta' THEN @NuevoValor ELSE Consulta END,
    ObraSocialFK = CASE WHEN @Atributo = 'ObraSocialFK' THEN @NuevoValor ELSE ObraSocialFK END
WHERE ID = @ID;

--Actualizar los atributos de una historia clínica en la tabla HistoriasClinicas
UPDATE HistoriasClinicas SET
    Fecha = CASE WHEN @Atributo = 'Fecha' THEN @NuevoValor ELSE Fecha END,
    MotivoVisita = CASE WHEN @Atributo = 'MotivoVisita' THEN @NuevoValor ELSE MotivoVisita END,
    Sintomas = CASE WHEN @Atributo = 'Sintomas' THEN @NuevoValor ELSE Sintomas END,
    Diagnostico = CASE WHEN @Atributo = 'Diagnostico' THEN @NuevoValor ELSE Diagnostico END,
    Tratamiento = CASE WHEN @Atributo = 'Tratamiento' THEN @NuevoValor ELSE Tratamiento END,
    UsuarioModelFK = CASE WHEN @Atributo = 'UsuarioModelFK' THEN @NuevoValor ELSE UsuarioModelFK END
WHERE ID = @ID;

--Actualizar los atributos de un estudio en la tabla Estudios
UPDATE Estudios SET
    Tipo = CASE WHEN @Atributo = 'Tipo' THEN @NuevoValor ELSE Tipo END,
    Especificaciones = CASE WHEN @Atributo = 'Especificaciones' THEN @NuevoValor ELSE Especificaciones END,
    Fecha = CASE WHEN @Atributo = 'Fecha' THEN @NuevoValor ELSE Fecha END,
    HistoriasClinicasFK = CASE WHEN @Atributo = 'HistoriasClinicasFK' THEN @NuevoValor ELSE HistoriasClinicasFK END
WHERE ID = @ID;

--Actualizar los atributos de una medicación en la tabla Medicacion
UPDATE Medicacion SET
    Droga = CASE WHEN @Atributo = 'Droga' THEN @NuevoValor ELSE Droga END,
    Prescripcion = CASE WHEN @Atributo = 'Prescripcion' THEN @NuevoValor ELSE Prescripcion END,
    Receta = CASE WHEN @Atributo = 'Receta' THEN @NuevoValor ELSE Receta END,
    Fecha = CASE WHEN @Atributo = 'Fecha' THEN @NuevoValor ELSE Fecha END,
    HistoriasClinicasFK = CASE WHEN @Atributo = 'HistoriasClinicasFK' THEN @NuevoValor ELSE HistoriasClinicasFK END
WHERE ID = @ID;