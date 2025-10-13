-- BANCO DE DADOS - Vendas Online
CREATE DATABASE VendasOnline;
GO
USE VendasOnline;
GO

CREATE TABLE StatusPedido (
    StatusId INT IDENTITY(1,1) PRIMARY KEY,
    Nome     VARCHAR(40) NOT NULL
);
GO

CREATE TABLE Categoria (
    CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
    Nome        VARCHAR(60) NOT NULL
);

GO

CREATE TABLE Cliente (
    ClienteID    INT IDENTITY(1,1) PRIMARY KEY,
    Nome         VARCHAR(50) NOT NULL,
    Sobrenome    VARCHAR(50) NOT NULL,
    Email        VARCHAR(100) UNIQUE,
    Telefone     VARCHAR(20),
    DataCadastro DATE NOT NULL DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME())
);

GO

CREATE TABLE Produto (
    ProdutoID          INT IDENTITY(1,1) PRIMARY KEY,
    CategoriaID        INT NOT NULL,
    Nome               VARCHAR(120) NOT NULL,
    Preco              DECIMAL(10,2) NOT NULL CHECK (Preco >= 0),
    QuantidadeEstoque  INT NOT NULL CHECK (QuantidadeEstoque >= 0),
    CONSTRAINT FK_Produto_Categoria FOREIGN KEY (CategoriaID) REFERENCES Categoria(CategoriaID)
);

GO

CREATE TABLE Pedido (
    PedidoID    INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID   INT NOT NULL,
    DataPedido  DATE NOT NULL DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME()),
    ValorTotal  DECIMAL(10,2) NOT NULL DEFAULT 0,
    StatusID    INT NOT NULL,
    CONSTRAINT FK_Pedido_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    CONSTRAINT FK_Pedido_Status  FOREIGN KEY (StatusID)  REFERENCES StatusPedido(StatusId)
);

GO

CREATE TABLE DetalhesPedido (
    DetalheID     INT IDENTITY(1,1) PRIMARY KEY,
    PedidoID      INT NOT NULL,
    ProdutoID     INT NOT NULL,
    Quantidade    INT NOT NULL CHECK (Quantidade > 0),
    PrecoUnitario DECIMAL(10,2) NOT NULL CHECK (PrecoUnitario >= 0),
    CONSTRAINT FK_Detalhes_Pedido  FOREIGN KEY (PedidoID)  REFERENCES Pedido(PedidoID),
    CONSTRAINT FK_Detalhes_Produto FOREIGN KEY (ProdutoID) REFERENCES Produto(ProdutoID)
);

GO

-- INSERINDO DADOS

INSERT INTO StatusPedido (Nome) VALUES 
('Novo'), 
('Enviado'), 
('Cancelado');

GO

INSERT INTO Categoria (Nome) VALUES 
('Informática'), 
('Acessórios');

GO

INSERT INTO Cliente (Nome, Sobrenome, Email, Telefone, DataCadastro) VALUES
('João', 'Silva', 'joao@email.com', '11999999999', '2025-04-09');
GO

INSERT INTO Produto (CategoriaID, Nome, Preco, QuantidadeEstoque) VALUES
(1, 'Notebook X', 4500.00, 10),
(2, 'Mouse Óptico', 50.00, 100);
GO

--PROCEDURES
--Procedure facilita a entrada de dados deixando menos verboso na hora de inserir

--Procedure 1: Inserir Clientes
CREATE PROCEDURE InserirCliente
@Nome VARCHAR(50),
@Sobrenome VARCHAR(50),
@Email VARCHAR(100),
@Telefone VARCHAR(20),
@DataCadastro DATE

AS 
BEGIN
    --Para nao ficar mostrando as informacoes alteradas
    SET NOCOUNT ON
    INSERT INTO CLIENTE(Nome, Sobrenome, Email, Telefone, DataCadastro)
    VALUES(@Nome, @Sobrenome, @Email, @Telefone, @DataCadastro)
END

--TESTANDO PROCEDURE
EXEC InserirCliente 
'Ana', 'Sousa', 'ana@gmail.com', '11999999', '2025-10-13'

SELECT * FROM Cliente

--Procesure 2: Inserir Pedido
CREATE PROCEDURE InserirPedido
    @ClienteId INT,
    @DataPedido DATE,
    @ValorTotal DECIMAL(10,2),
    @StatusID INT

AS
BEGIN
    SET NOCOUNT ON
    INSERT INTO Pedido(ClienteID, DataPedido, ValorTotal, StatusID)
    VALUES(@ClienteId, @DataPedido, @ValorTotal, @StatusId)
END

--TESTANDO PROCEDURE
EXEC InserirPedido 2, '2025-10-13', 250.00, 1

SELECT * FROM Pedido

--PROCEDURE 3: Atualizar preco do produto
CREATE PROCEDURE AtualizarPrecoProduto
    @ProdutoID INT,
    @PercentualAumento DECIMAL(5,2)
AS
BEGIN
    SET NOCOUNT ON
    UPDATE PRODUTO
        SET Preco = Preco * (1+ @PercentualAumento /100.0)
        WHERE ProdutoID = @ProdutoId
END

--Testando PROCEDURE
SELECT * FROM Produto

EXEC AtualizarPrecoProduto 2,10