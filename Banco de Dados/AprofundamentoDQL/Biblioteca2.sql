CREATE DATABASE BIBLIOTECA2;
GO

USE BIBLIOTECA2;
GO

CREATE TABLE Autor (
	id_Autor INT PRIMARY KEY,
	nome VARCHAR(100) NOT NULL
	);
GO

CREATE TABLE Livro (
	id_Livro INT PRIMARY KEY,
	titulo VARCHAR(150) NOT NULL,
	ano INT,
	id_Autor INT NOT NULL,
	CONSTRAINT fk_livro_autor FOREIGN KEY (id_Autor) REFERENCES Autor(id_Autor) ON DELETE CASCADE
	);
GO

CREATE TABLE Leitor (
	id_Leitor INT PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	email VARCHAR (120) UNIQUE
	);
GO

CREATE TABLE Emprestimo (
	id_Emprestimo INT PRIMARY KEY,
	id_Livro INT NOT NULL,
	id_Leitor INT NOT NULL,
	data_emprestimo DATE NOT NULL, 
	data_devolucao DATE,
	CONSTRAINT fk_empr_livro FOREIGN KEY (id_Livro) REFERENCES Livro(id_Livro) ON DELETE CASCADE,
	CONSTRAINT fk_empr_leitor FOREIGN KEY (id_Leitor) REFERENCES Leitor(id_Leitor) ON DELETE CASCADE
	);
GO

INSERT INTO Autor VALUES 
  (1,'Machado de Assis'),
  (2,'Clarice Lispector'),
  (3,'J. K. Rowling'),
  (4,'Shakespeare');
GO

INSERT INTO Livro VALUES 
	(1, 'Dom Casmurro', 1899, 1),
	(2, 'Memórias Póstumas de Brás Cubas', 1881, 1),
	(3, 'A hora da estrela', 1977, 2),
	(4, 'O sonho de uma noite de verão', 1600, 4),		
	(5, 'Harry Potter e o calice de fogo', 2000, 3);
GO

INSERT INTO Leitor VALUES
	(1, 'Thiago Oliveira' , 'thiago@gmail.com'),
	(2, 'Caique' , 'caique@gmail.com'),
	(3, 'Odirlei' , 'odi@gmail.com' ),
	(4, 'Kessia', 'kessia@gmail.com');
GO

INSERT INTO Emprestimo VALUES --id_emprestimo, id_livro, id_leitor, data_empr, data_dev
	(1, 5, 1, '2025-09-02', '2025-09-09'), -- Thiago pegou harry potter
	(2, 4, 4, '2025-08-27', '2025-09-05'), -- kessia pegou o sonho de uma noite
	(3, 1, 2, '2025-05-01', '2025-06-10'); --caique pegou Dom casmurro
GO

INSERT INTO Emprestimo VALUES
(4,3,2,'2025-05-01', '2025-06-10')

INSERT INTO Emprestimo VALUES
(5,2,2,'2025-05-01', '2025-12-10')

INSERT INTO Autor VALUES
(6, 'Stan Lee')

-- FUNCOES AGREGADAS

-- Exercicio 1
SELECT COUNT(id_Livro) AS Quantidade 
FROM Livro

--Exercicio 2
--AVG faz a media dos valores
SELECT AVG(ANO) AS MediaAno
FROM Livro

--Exercicio 3
SELECT l.nome, COUNT(e.id_Emprestimo) AS NumeroEmprestimos FROM Leitor l
INNER JOIN Emprestimo e ON l.id_Leitor = e.id_Leitor
GROUP BY l.nome
WHERE MAX(e.id_Emprestimo)



--FUNCOES de TEXTO

--Exercicio 1
SELECT LEFT(nome,3) FROM Autor

--Exercicio 2
SELECT LOWER(titulo) FROM Livro

--Exercicio 3
SELECT email FROM Leitor
WHERE RIGHT(email, 4) = '.com'

--Exercicio 4
SELECT REPLACE(titulo, 'estrela', 'sol') FROM Livro
WHERE id_Livro = 3

--FUNCOES DE DATA E HORA

--Exercicio 1
SELECT id_Emprestimo, id_Livro, DATEPART(MONTH, data_emprestimo) AS MesEmprestimo  FROM Emprestimo
WHERE MONTH(data_emprestimo) = 8

--Exercicio 2
SELECT DATEDIFF(DAY, MIN(data_emprestimo) , MAX(data_emprestimo)) AS ComparacaoDias FROM Emprestimo

--Exercicio 3
SELECT id_Emprestimo, data_emprestimo, DATENAME(WEEKDAY, data_emprestimo) AS Semana FROM Emprestimo

--OPERADORES DE COMPARACAO LOGICOS

--Exercicio 1
SELECT * FROM Livro
WHERE ano BETWEEN 1950 AND 2005

--Exercicio 2
SELECT * FROM Leitor
WHERE LEFT(nome,1) = 'C'

--Exercicio 3
SELECT * FROM Emprestimo
WHERE YEAR(data_emprestimo) = 2025
AND data_devolucao > GETDATE()

--Exercicio 4
SELECT * FROM Autor a
LEFT JOIN Livro l ON l.id_Autor = a.id_Autor
WHERE l.id_Autor IS NULL