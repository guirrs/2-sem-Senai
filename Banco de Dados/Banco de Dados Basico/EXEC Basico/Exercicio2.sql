CREATE DATABASE Escola

USE Escola;

CREATE TABLE Aluno(
IdAluno INT PRIMARY KEY,
Nome NVARCHAR(100),
Idade INT,
Cidade NVARCHAR(100)
);

INSERT INTO Aluno(IdAluno, Nome, Idade, Cidade)
VALUES
(1, 'Aristoteles', 56, 'GreciaTime'),
(2, 'Afonso', 43,  'Itaquera'),
(3, 'Carlos', 15, 'Mongi'),
(4, 'Rebeca', 19, 'Ubatuva'),
(5, 'Cristian', 17, 'Itaquera');

--Tarefa 3
UPDATE Aluno SET Cidade = 'Ubatuba'
Where Cidade = 'Ubatuva'
SELECT * FROM Aluno;

SELECT * FROM Aluno
WHERE Idade > 20;

SELECT * FROM Aluno
WHERE Cidade Like '%Itaquera%'
