DROP DATABASE Loja
GO

CREATE DATABASE Loja
GO

USE Loja

CREATE TABLE Cliente(
ClienteID	INT IDENTITY(100,1),
--NOT NULL impede de inseriar informacoes em uma tabela caso esse espaco nao tenha informacoes
Nome		VARCHAR(50) NOT NULL,
Email		NVARCHAR(250) UNIQUE,
--PK: Chave Primaria
CONSTRAINT PK_Cliente PRIMARY KEY (ClienteID)
);

CREATE TABLE Pedido(
PedidoID		INT IDENTITY(100,1),
DataPedido		DATE NOT NULL,
Valor			DECIMAL(10,2),
ClienteID		INT,
CONSTRAINT Pk_Pedido PRIMARY KEY (PedidoID),
--Fk: Foreign key
CONSTRAINT Fk_Pedido FOREIGN KEY (ClienteID)
REFERENCES Cliente(ClienteID) --ON DELETE CASCADE
);

INSERT INTO Cliente VALUES -- (Nome,Email)
('Thiago Augusto', 'titi@senai.com'),
('Kessia Milena', NULL),
('Ordiley', 'ordiley@senai.com')

INSERT INTO Pedido VALUES --(DataPedido, Valor, ClienteID)
('2025-10-01', '100.80', 100),
('2025-09-10', '49.99', 100),
('2025-09-23', '350.00', 101)

SELECT * FROM Cliente
SELECT * FROM Pedido


--Ajustar e-mail de cliente
UPDATE Cliente SET Email = 'kessia@gmail.com'
WHERE ClienteID = 101;

-- Atualizar o valor de um pedido
UPDATE Pedido SET Valor = Valor + '10.00'
WHERE PedidoID = 101

SELECT * FROM Pedido


--Renomear a tabela cliente para Funcionario
EXEC sp_rename 'Cliente', 'Funcionario'

SELECT * FROM Funcionario
SELECT * FROM Pedido



--Renomear a coluna ClienteID por FuncionarioID
EXEC sp_rename 'ClienteID', 'Funcionario.ClienteID', 'COLUMN'

--Alterar tamanho do tipo de dados
ALTER TABLE Funcionario
ALTER COLUMN Nome NVARCHAR(250) NOT NULL;

--Ver a estrutura da tabela
EXEC sp_help 'Funcionario'


--Deletar um funcionario
DELETE Funcionario
WHERE FuncionarioID = 100

--Apagar a chave primario da tabela Pedido
ALTER TABLE Pedido
DROP CONSTRAINT Pk_Pedido;

SELECT * FROM Pedido

--Recriando a chave primaria
ALTER TABLE Pedido
ADD CONSTRAINT Pk_Pedido PRIMARY KEY (PedidoID)

--Alterar a tabela pedido
--ON DELETE CASCADE
ALTER TABLE Pedido
DROP CONSTRAINT Fk_Pedido

--RECRIAR FK com ON DELETE CASCADE
ALTER TABLE Pedido 
ADD CONSTRAINT Fk_Pedido_Cliente
FOREIGN KEY (CLienteID) REFERENCES Funcionario(FuncionarioID)
ON DELETE CASCADE 

SELECT * FROM Funcionario

SELECT * FROM Pedido

--Adicionar novas colunas
ALTER TABLE Funcionario
ADD Cargo NVARCHAR(50)

SELECT * FROM Funcionario