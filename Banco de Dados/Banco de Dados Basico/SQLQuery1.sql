-- Apagar a base dde dados ja existente
DROP DATABASE Empresa;

-- Criar base de dados Empresa
CREATE DATABASE Empresa;

--Acessar a base de dados criada
USE Empresa;

--Criar tabela Funcionario
CREATE TABLE Funcionario(
--Em banco de dados o tipo de variavel eh declarado dps e poe PRIMARY KEY pois eh uma chave primaria, nao deixando os valores repetirem
Codigo INT PRIMARY KEY,
-- NVARCHAR permite o uso de letras e acentos
Nome NVARCHAR(100)
);

--Inserindo valores em uma tabela
-- INSERT TO eh inserir em, permitindo adicionar valores a tabela
INSERT INTO Funcionario (Codigo, Nome)
VALUES
(1, 'Kessia'),
(2,'Thiago')

INSERT INTO Funcionario VALUES
(3, 'Ordilei');

--Listar dados inseridos
--SELECT * FROM vai mostrar em resultados tudo que estiver em funcionarios
SELECT * FROM Funcionario;

--Listar nomes de funcionario
SELECT Nome, Codigo FRom Funcionario

--Listar funcionarios com cod > 2
SELECT * FROM Funcionario
WHERE Codigo > 2;

--Listar funcionario que comecam com a letra T
SELECT * FROM Funcionario
--LIKE funciona para indetificar um valor e a % dentro quer dizer ao computador que tem mais conteudo
WHERE Nome LIKE 'T%';

SELECT * FROM Funcionario
--Duas porcentagens procura todo conteudo que tenha A
WHERE Nome LIKE '%A%';

-- Ordenar valores
SELECT * FROM Funcionario
--ORDER BY variavel DESC ordena de forma decrecente, sendo ORDER BY (variavel) FUNCAO
ORDER BY Codigo DESC;

-- Ordernar por letra (ordem alfabetica)
SELECT * FROM Funcionario
ORDER BY Nome ASC;

-- DESC - Descrecente
--ASC - Crescente

-- Atualizacao de registros
-- UPDATE Eh um update do banco, o SET auxilia na alteracao e depois tem que por um filtro, para nao mudar todos os funcionarios
UPDATE Funcionario SET Nome = 'Kessia Milena'
WHERE Nome = 'Kessia';

SELECT * FROM Funcionario 

-- Atualizacao sem update(sem fazer)
UPDATE Funcionario SET Nome = 'Thiago';

-- Exclusao de dados
-- NAO ESQUECER DO WHERE
DELETE FROM Funcionario
WHERE Codigo = 1;

SELECT * FROM Funcionario