CREATE DATABASE EventosConferencias
GO

USE EventosConferencias
GO

CREATE TABLE Palestrante(
ID_Palestrante INT PRIMARY KEY,
Nome_Palestrante NVARCHAR(50)
)
GO

INSERT INTO Palestrante(ID_Palestrante, Nome_Palestrante)
VALUES
(1, 'Gerso'),
(2, 'Julmar'),
(3, 'Gabigol'),
(4, 'Jubiscrelda')


CREATE TABLE Palestra(
ID_Palestra INT PRIMARY KEY,
Titulo NVARCHAR(100),
ID_Palestrante INT FOREIGN KEY REFERENCES Palestrante(ID_Palestrante)
)
GO

INSERT INTO Palestra(ID_Palestra, Titulo, ID_Palestrante)
VALUES
(21, 'Quem nao chora nao mama', 4),
(54, 'Nao eh pq sou bobo que cai na casca do ovo', 2),
(72, 'O Jiu jitsu eh uma ratoeira', 1)


CREATE TABLE Participante(
ID_Participante INT PRIMARY KEY,
Nome_Participante NVARCHAR(50),
Email NVARCHAR(250) UNIQUE
)
GO

INSERT INTO Participante(ID_Participante, Nome_Participante, Email)
VALUES
(151, 'Francisco', 'franciscotop@gmail.com'),
(152, 'Rogerio', 'rogerio34234@gmail.com'),
(153, 'Samuel', 'chamasamu@gmail.com'),
(154, 'Felipe', 'felipecontatos@gmail.com'),
(155, 'Silva', 'silvinha1234@gmail.com'),
(156, 'Supremo', 'supremo@gmail.com')

CREATE TABLE Inscricao(
ID_inscricao INT PRIMARY KEY,
ID_Palestra INT FOREIGN KEY REFERENCES Palestra(ID_Palestra),
ID_Participante INT FOREIGN KEY REFERENCES Participante(ID_Participante)
)
GO

INSERT INTO Inscricao(ID_inscricao, ID_Palestra, ID_Participante)
VALUES
(743, 21, 151),
(744, 21, 153),
(745, 21, 152),
(746, 54, 156),
(747, 54, 155),
(748, 54, 151),
(749, 54, 154)

-- Todas incricoes que tem palestra
SELECT d.Nome_Palestrante, p.ID_Palestrante, p.Titulo, p.ID_Palestra , i.ID_inscricao FROM Inscricao i
FULL JOIN Palestra p ON p.ID_Palestra = i.ID_Palestra
LEFT JOIN Palestrante d ON d.ID_Palestrante = p.ID_Palestrante

-- Nome dos participantes que vao a palestra 'Nao eh pq sou bobo que cai na casca do ovo'
SELECT e.Titulo, i.ID_Participante, p.Nome_Participante, e.ID_Palestrante, d.Nome_Palestrante FROM Inscricao i
INNER JOIN Participante p ON p.ID_Participante = i.ID_Participante
RIGHT JOIN Palestra e ON e.ID_Palestra = i.ID_Palestra
INNER JOIN Palestrante d ON d.ID_Palestrante = e.ID_Palestrante
WHERE i.ID_Palestra = 54

--Todos os palestrantes que tem palestras
SELECT d.ID_Palestrante, d.Nome_Palestrante, e.Titulo  FROM Palestra e
FULL JOIN Palestrante d ON d.ID_Palestrante = e.ID_Palestrante


--Recriando as tabelas para terem CONSTRAIN

--INSCRICAO
DROP TABLE Inscricao

CREATE TABLE Inscricao
(
ID_inscricao INT IDENTITY(743,1),
ID_Palestra INT,
ID_Participante INT,

CONSTRAINT Pk_Inscricao PRIMARY KEY (ID_Inscricao),
CONSTRAINT Fk_Palestra FOREIGN KEY (ID_Palestra)
REFERENCES Palestra(ID_Palestra),
CONSTRAINT Fk_Participante FOREIGN KEY (ID_Participante)
REFERENCES Participante(ID_Participante)
)

INSERT INTO Inscricao(ID_Palestra, ID_Participante)
VALUES
(21, 150),
(21, 153),
(21, 152),
(54, 155),
(54, 155),
(54, 151),
(54, 154)

--PALESTRA
DROP TABLE Palestra

CREATE TABLE Palestra(
ID_Palestra INT,
Titulo NVARCHAR(100),
ID_Palestrante INT,

CONSTRAINT Pk_Palestra PRIMARY KEY(ID_Palestra),

CONSTRAINT Fk_Palestrante FOREIGN KEY(ID_Palestrante)
REFERENCES Palestrante(ID_Palestrante)
)

INSERT INTO Palestra(ID_Palestra, Titulo, ID_Palestrante)
VALUES
(21, 'Quem nao chora nao mama', 4),
(54, 'Nao eh pq sou bobo que cai na casca do ovo', 2),
(72, 'O Jiu jitsu eh uma ratoeira', 1)

--PALESTRANTE
DROP TABLE Palestrante

CREATE TABLE Palestrante(
ID_Palestrante INT,
Nome_Palestrante NVARCHAR(50)
CONSTRAINT Pk_Palestrante PRIMARY KEY(ID_Palestrante)
)

INSERT INTO Palestrante(ID_Palestrante, Nome_Palestrante)
VALUES
(1, 'Gerso'),
(2, 'Julmar'),
(3, 'Gabigol'),
(4, 'Jubiscrelda')

--Participante
DROP TABLE Participante

CREATE TABLE Participante(
ID_Participante INT IDENTITY(150,1),
Nome_Participante NVARCHAR(50),
Email NVARCHAR(250) UNIQUE,

CONSTRAINT Pk_Participante PRIMARY KEY(ID_Participante)
)

INSERT INTO Participante(Nome_Participante, Email)
VALUES
('Francisco', 'franciscotop@gmail.com'),
('Rogerio', 'rogerio34234@gmail.com'),
('Samuel', 'chamasamu@gmail.com'),
('Felipe', 'felipecontatos@gmail.com'),
('Silva', 'silvinha1234@gmail.com'),
('Supremo', 'supremo@gmail.com')

 --Mudar o nome da Inscricao para Ingresso

 EXEC sp_rename 'Inscricao', 'Ingresso'

 SELECT * FROM Ingresso

--Adicionar preco pago nas inscricoes
ALTER TABLE Ingresso
ADD Valor MONEY

SELECT * FROM Ingresso

UPDATE Ingresso SET Valor = '100.00'
WHERE ID_Palestra = 21

UPDATE Ingresso SET Valor = '80.00'
WHERE ID_Palestra = 54
 

 --RECRIAR FK de ID_Palestra e ID_Palestrante com ON DELETE CASCADE na inscricao

 ALTER TABLE Ingresso
 DROP CONSTRAINT Fk_Palestra

 ALTER TABLE Ingresso
 ADD CONSTRAINT Fk_Palestra_Inscricao
 FOREIGN KEY (ID_Palestra) REFERENCES Palestra(ID_Palestra)
 ON DELETE CASCADE

 ALTER TABLE Ingresso
 DROP CONSTRAINT Fk_Participante

 ALTER TABLE Ingresso
 ADD CONSTRAINT Fk_Participante_Ingresso
 FOREIGN KEY (ID_Participante) REFERENCES Participante(ID_Participante)
 ON DELETE CASCADE

  --Deletar uma inscricao de acordo com as normas gracas ao ON DELETE CASCADE
 DELETE FROM Ingresso
 WHERE ID_inscricao  = '749'


 SELECT * FROM Ingresso
 SELECT * FROM Palestra
 SELECT * FROM Participante




