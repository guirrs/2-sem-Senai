--DDL - Linguagem de definicao de dados


CREATE DATABASE Clinica_medica;
GO

USE Clinica_Medica;
GO

CREATE TABLE Paciente
(
CPF NVARCHAR(14) PRIMARY KEY,
Nome VARCHAR(50),
Telefone NVARCHAR(30),
NumeroPlano INT,
NomePlano NVARCHAR(50)
)

CREATE TABLE Medico(
CRM INT PRIMARY KEY,
NomeMedico NVARCHAR(50),
Especialidade NVARCHAR(30)
)

-- TABELA CONSULTA
CREATE TABLE Consulta(
--IDENTITY em PRIMARY KEY ele poe um padrao e toda vez que voce adicionar uma consulta, 
-- seguira ele como o informado => (valorInicial, ValorAdicionado)
NumeroConsulta INT PRIMARY KEY IDENTITY(100,1),
--DATE marca o dia inserido
DataConsulta DATE,
--TIME o Horario inserido
HorarioConsulta TIME,
-- FOREING KEY eh a chave estrangeira, depois use REFERENCES para indicar onde esta essa chame de pois use a TABLE(Atributo que deseja)
CRM INT FOREIGN KEY REFERENCES Medico(CRM),
CPF NVARCHAR(14) FOREIGN KEY REFERENCES Paciente(CPF)
);
GO

SELECT * FROM Paciente;
SELECT * FROM Medico;
SELECT * FROM Consulta;

--1. Inserir dados na tabela Paciente.
INSERT INTO Paciente(CPF, Nome, Telefone, NumeroPlano, NomePlano)
VALUES
('233.451.278-64', 'Romario', 11-976207465, 3, 'Intermedica'),
('543.451.576-73', 'Armando', 11-946213257, 2, 'Mercosul'),
('489.256.479-21', 'Laura', 11-947916540, 1, 'Mercosul'),
('287.594.637-26', 'Ribamar', 11-978950351, 7, 'Maisvoce'),
('467.354.929-12', 'Leandro', 11-954723912, 5, 'Intermedica'),
('574.923.842-74', 'Romario', 11-985672301, 2, 'Mercosul')

UPDATE Paciente SET Nome = 'Vicente'
WHERE CPF = '574.923.842-74'

--2. Inserir dados na tabela Medico.
INSERT INTO Medico(CRM, NomeMedico, Especialidade)
VALUES
(142364, 'Julio', 'Neurologista'),
(342756, 'Lidia', 'Dermatologista'),
(674832, 'Alessandro', 'Radiologista'),
(875921, 'Sandra', 'Pediatra'),
(674980, 'Leticia', 'Gastroenterologista')

--3. Inserir consultas médicas.
INSERT INTO Consulta(DataConsulta, HorarioConsulta, CRM, CPF)
VALUES
('2025/9/27', '14:53', 142364, '287.594.637-26'),
('2025/9/27', '15:00', 875921, '233.451.278-64')

UPDATE Consulta SET DataConsulta = '2025-9-27'

--4. Listar todos os pacientes cadastrados.
SELECT * FROM Paciente;

--5. Listar todos os médicos e suas especialidades.
SELECT * FROM Medico;

--6. Buscar todas as consultas agendadas.
SELECT p.Nome, c.DataConsulta, m.NomeMedico, p.Nome AS 'Nome Paciente'
FROM Paciente p
RIGHT JOIN Consulta c ON p.CPF = c.CPF
LEFT JOIN Medico m ON c.CRM = m.CRM

--7. Buscar consultas de um paciente específico.
SELECT * FROM Consulta
WHERE CPF LIKE '287.594.637-26'

--8. Buscar consultas de um médico específico.
SELECT * FROM Consulta
WHERE CRM LIKE 875921

--9. Atualizar o número do plano de três pacientes.
UPDATE Paciente SET NumeroPlano = '8'
WHERE Nome = 'Laura'

UPDATE Paciente SET NumeroPlano = '3'
WHERE Nome = 'Ribamar'

UPDATE Paciente SET NumeroPlano = '7'
WHERE Nome = 'Romario'

--10. Deletar dois pacientes do sistema.
DELETE FROM Paciente 
WHERE Nome = 'Armando'

DELETE FROM Paciente 
WHERE Nome = 'Leandro'

--11. Inserir novos dados
INSERT INTO Medico(CRM, NomeMedico, Especialidade)
VALUES
(234521, 'Felipe', 'Urologista'),
(345876, 'Gabriely', 'Ortopedista')

INSERT INTO Paciente(CPF, Nome, Telefone, NumeroPlano, NomePlano)
VALUES
('532.321.543-76', 'Ribamar', 11-943729856, 7, 'Maisvoce'),
('765.423.234-65', 'Vitoria', 11-976850291, 5, 'Maisvoce'),
('743.123.865-53', 'Cassio', 11-909375543, 2, 'Maisvoce')

--12. Atualizar informações de médicos
UPDATE Medico SET Especialidade = 'otorrinolaringologista'
WHERE NomeMedico = 'Gabriely'

UPDATE Medico SET Especialidade = 'coloproctologista'
WHERE NomeMedico = 'Felipe'


--Consulta 100 - Paciente 111 
--Voce pode simplificar o codigo colocando a primerira letra da Table
--Portanto que voce declare de onde foi
SELECT c.NumeroConsulta, c.DataConsulta, c.HorarioConsulta, p.Nome, m.NomeMedico
FROM Consulta c
--INNER JOIN / JOIN
--JOIN Ele vai pegar as duas tabelas e criar uma nova. Caso seja LEFT JOIN voce vai dar prioridade para a
--tabela da esquerda, ou seja, se nao tiver nada na tabela da direita que seja semelhante, vai aparecer nulo
--RIGHT eh a mesma logica. Caso use INNER voce vai trazer apenas os valores que elas tem em comum.
INNER JOIN Paciente p ON c.CPF = p.CPF
INNER JOIN Medico  m ON c.CRM = m.CRM

--LEFT JOIN
-- AS muda o nome do atributo na tabela
SELECT p.Nome, c.DataConsulta, m.NomeMedico, p.Nome AS 'Nome Paciente'
FROM Paciente p
--LEFT JOIN vai buscar tudo da esquerda, nesse casa vai buscar todos os pacientes mesmo que nao tenham consulta
LEFT JOIN Consulta c ON p.CPF = c.CPF
LEFT JOIN Medico m ON c.CRM = m.CRM

--RIGHT JOIN
SELECT m.NomeMedico, m.Especialidade, c.DataConsulta, p.Nome
FROM Consulta c
-- RIGHT pegou todos on conteudos da direita enquanto LEFT pega o da esquerda
RIGHT JOIN Medico m ON c.CRM = m.CRM
LEFT JOIN Paciente p ON c.CPF = p.CPF



--DICIONARIO DE DADOS
SELECT * FROM sys.tables

SELECT name, create_date, modify_date
FROM sys.tables

SELECT * FROM sys.columns
WHERE object_id = OBJECT_ID('Paciente')

--Vizualizarr os tipos de dados no sistema
SELECT * FROM sys.types

-- Consulta de todos juntos com o JOIN
SELECT tabelas.name AS Tabela, colunas.name AS Colunas, tipo.name AS Tipo, colunas.max_length AS Tamanho,
colunas.is_nullable AS PermiteNulo
FROM sys.tables tabelas
JOIN sys.columns colunas ON tabelas.object_id = colunas.object_id
JOIN sys.types tipo ON colunas.user_type_id = tipo.user_type_id
ORDER BY tabelas.name, colunas.column_id
