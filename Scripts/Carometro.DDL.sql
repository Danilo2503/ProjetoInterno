CREATE DATABASE Carometro

USE Carometro

CREATE TABLE Turma
(
	IdTurma INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(200) NOT NULL
);

CREATE TABLE Aluno
(
	IdAluno INT PRIMARY KEY IDENTITY,
	IdTurma INT FOREIGN KEY REFERENCES Turma (IdTurma),
	Nome VARCHAR(200) NOT NULL,
	Email VARCHAR(200) NOT NULL,
	Telefone VARCHAR(200) NOT NULL
);

CREATE TABLE TipoUsuario
(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(200) NOT NULL
);

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario),
	Nome VARCHAR(200) NOT NULL,
	Email VARCHAR(200) NOT NULL,
	Senha VARCHAR(200) NOT NULL
);