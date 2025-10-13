CREATE DATABASE Loja;

USE Loja

CREATE TABLE Jogo(
IdJogo INT PRIMARY KEY,
Titulo NVARCHAR(50),
Genero NVARCHAR(50),
Preco INT
);

INSERT INTO Jogo(IdJogo, Titulo, Genero, Preco)
VALUES
(1, 'The Last of Us', 'Acao', 550),
(2, 'Naruto', 'Luta', 160),
(3, 'Red Dead Redention 2', 'Aventura', 350),
(4, 'Call of Duty Black Ops', 'Acao', 220),
(5, 'Holow Knight', 'Aventura', 60);

--Tarefa 3
SELECT * FROM Jogo
WHERE Genero = 'Acao'

SELECT * FROM Jogo
WHERE Preco > 200

SELECT Titulo, Preco FROM Jogo 