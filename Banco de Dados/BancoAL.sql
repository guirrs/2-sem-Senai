CREATE DATABASE AurumLab

USE AurumLab
DROP TABLE Regra

CREATE TABLE Regra(
	ID_Regra		INT IDENTITY(1,1),
	Nome			VARCHAR(40) NOT NULL UNIQUE,
	
	CONSTRAINT Pk_Regra PRIMARY KEY(ID_Regra)
	)

CREATE TABLE Usuario(
ID_Usuario		INT IDENTITY(1,1),
NomeCompleto	NVARCHAR(120) NOT NULL,
Email			NVARCHAR(150) NOT NULL UNIQUE,
Senha			VARBINARY(32) NOT NULL, --armazena a senha da hash
--NULL permite que o valor seja nulo
FotoURL			NVARCHAR(500) NULL, --armazena o caminho da URL
--A diferenca do DATETIME normal pega o falor de ate 1953, o DATETIME2 vai ate o nascimento de cristo
-- 0 casas decimais no segundo
--DEFAULT vai deixar um valor padrao caso o valor seja NOT NULL, ATRIBUTO DEFAULT ATRIBUTO
CriadoEM		DATETIME2(0) NOT NULL DEFAULT DATEADD(HOUR, -3, sysutcdatetime()),
ID_Regra		INT NOT NULL,

CONSTRAINT Pk_Usuario PRIMARY KEY(ID_Usuario),
CONSTRAINT Fk_Usuario_Regra FOREIGN KEY (ID_Regra) REFERENCES Regra(ID_Regra)
)


SELECT * FROM Usuario

INSERT INTO Regra (Nome) VALUES
('Aluno'),
('Professor')

SELECT * FROM Regra

--DECLARE eh uma declaracao, nessa crio uma variavel temporaria que vai receber os valores que deseja
DECLARE @ID_Regra INT
SET @ID_Regra = 
(SELECT ID_Regra FROM Regra WHERE Nome = 'Aluno')

INSERT INTO Usuario (NomeCompleto, Email, Senha, FotoURL, ID_Regra)
VALUES
--HASHBYTE eh um algoritimo para cripitograr a informacao
('Usuario 1', 'usuario@senai.com', HASHBYTES('SHA2_256', 'senha123'), '', @ID_Regra)

SELECT * FROM Usuario