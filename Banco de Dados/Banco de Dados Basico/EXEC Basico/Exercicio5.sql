CREATE DATABASE Sistema

USE Sistema

CREATE TABLE Livro(
Codigo INT PRIMARY KEY,
Titulo NVARCHAR(100),
Autor NVARCHAR(150),
Publicacao INT
)

INSERT INTO Livro(Codigo, Titulo, Autor, Publicacao)
VALUES
(1, 'Filosofia', 'Nelson Mandela', 1899),
(2, 'Choro de Rua', 'Matheus Castro', 2018),
(3, 'Viva ao Rei', 'Jorge Marquim', 2011),
(4, 'Solidadao em Convivio', 'Socrates', 0),
(5, 'A chave para o aprendizado', 'Guimaraes Rosa', 1923)

SELECT Titulo FROM Livro
WHERE Publicacao >= 2010

SELECT Titulo FROM Livro
WHERE Autor = 'Nelson Mandela'

SELECT Titulo FROM Livro
