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
SELECT * FROM Produto

--Procedure 4: Totale de vendas por cliente
CREATE PROCEDURE ObterTotalVendas
    @ClienteId INT,
    @TotalVendas DECIMAL(10,2) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    --COALESCE substitui valores nulos para zero
    SELECT @TotalVendas = COALESCE(SUM(ValorTotal), 0)
    FROM Pedido
    WHERE ClienteID = @ClienteId
END

--Testando Procedure
DECLARE @Total DECIMAL(10,2)
EXEC ObterTotalVendas 2, @Total OUTPUT
SELECT @Total AS ToralDeVendas

SELECT * FROM Pedido
WHERE ClienteID = 1

--PROCEDURE 5: Relatorio de Vendas por Cliente
CREATE PROCEDURE VendasPorCliente
    @DataLimite DATE
AS
BEGIN
    SET NOCOUNT ON

    SELECT C.ClienteID, C.Nome,
    SUM(D.Quantidade * D.PrecoUnitario) AS ToralGasto
    FROM Cliente C
    JOIN Pedido P           ON P.ClienteId = C.ClienteId
    JOIN DetalhesPedido D   ON D.PedidoId = P.PedidoId
    WHERE P.DataPedido < @DataLimite
    GROUP BY C.ClienteId, C.Nome
END

--Testando Procedure
INSERT INTO DetalhesPedido (PedidoId, ProdutoId, Quantidade, PrecoUnitario)
VALUES
(67,1,1,4500)

SELECT * FROM Pedido

EXEC VendasPorCliente '2025-10-14'

-- PROCEDURE 6: Historico Precos com tabela propria

CREATE TABLE HistoricoPreco(
    HistoricoID INT IDENTITY PRIMARY KEY,
    ProdutoID INT FOREIGN KEY REFERENCES Produto(ProdutoId),
    PrecoAntigo DECIMAL(10,2),
    PrecoNovo DECIMAL(10,2),
    DataModificacao DATE
    )

CREATE PROCEDURE AtualizarPrecoProdutoComHistorico
    @ProdutoID INT,
    @NovoPreco DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON
    DECLARE @PrecoAntigo DECIMAL(10,2)

    SELECT @PrecoAntigo = Preco
    FROM Produto
    WHERE ProdutoID = @ProdutoID

    UPDATE Produto SET Preco = @NovoPreco
    WHERE ProdutoID = @ProdutoID

    INSERT INTO HistoricoPreco
    (ProdutoID, PrecoAntigo,PrecoNovo, DataModificacao)
    VALUES (@ProdutoID, @PrecoAntigo, @NovoPreco, 
    DATEADD(HOUR, -3, SYSUTCDATETIME()))
END  

--TESTANDO PROCEDURE

EXEC AtualizarPrecoProdutoComHistorico 2,75.00

SELECT * FROM Produto
SELECT * FROM HistoricoPreco

--TRIGGERS

--TRigger 1: Auditoria de clientes inseridos
--Para se criar uma trigger usa trg_ como uma norma de criacao
CREATE TABLE Auditoria_Cliente(
    AuditoriaID INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT FOREIGN KEY REFERENCES Cliente(ClienteID),
    DataInsercao DATE
)

CREATE TRIGGER trg_Auditoria_CLiente
ON Cliente --Tabela que vai disparar a trigger
AFTER INSERT 
AS
BEGIN
    SET NOCOUNT ON
    INSERT INTO Auditoria_Cliente(ClienteID, DataInsercao)
    --SELECT ao FROM sao as VALUES
    SELECT ClienteID, DATEADD(HOUR, -3, SYSUTCDATETIME())
    --inserted eh uma tabela temporaria criada pela trigger que pode ser reutilizada por outra tabela
    FROM inserted
END

--TESTANDO A TRIGGER
INSERT INTO Cliente(Nome, Sobrenome, Email, Telefone, DataCadastro)
VALUES 
('Carlos', 'Pereira', 'carlos@gmail.com', '11999999999', '2025-10-14')

SELECT * FROM Auditoria_Cliente
SELECT * FROM Cliente

--TRIGGER 2: Atualizar o estoque ao Inserir um pedido
CREATE TRIGGER trg_AtualizacaoEstoque
ON DetalhesPedido
AFTER INSERT
AS 
BEGIN
    SET NOCOUNT ON
    UPDATE Produto
        SET QuantidadeEstoque = QuantidadeEstoque - i.Quantidade
        FROM Produto p
        JOIN inserted i ON p.ProdutoID = i.ProdutoID
END

--Testanto TRIGGER
SELECT * FROM Produto
SELECT * FROM Pedido
SELECT * FROM DetalhesPedido

INSERT INTO DetalhesPedido (PedidoID, ProdutoID, Quantidade, PrecoUnitario)
VALUES
(67,2,3,75.00)

--TRIGGER 3: Prevenir exclusao de produto com pedidos
CREATE TRIGGER trg_PrevinirExclusaoProdutos
ON Produto
--Ao inves de deletar
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON
    --EXISTS eh existir
    IF EXISTS (
    --O 1 pega o primeiro valor
        SELECT 1
            FROM DetalhesPedido dp
            JOIN deleted d ON dp.ProdutoID = d.ProdutoID
            )
    BEGIN 
        RAISERROR('Nao eh possivel exluir produto com pedidos associados', 16, 1)
        -- cod. de erro do usuario
    END

    DELETE FROM Produto
    WHERE ProdutoID IN (SELECT ProdutoID FROM deleted)
END

--TESTANDO TRIGGER
DELETE FROM Produto WHERE ProdutoID = 2

SELECT * FROM DetalhesPedido

--TRIGGER 4: Criar log de funcionario
CREATE TABLE Funcionario(
    FuncionarioID INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(50),
    CPF VARCHAR(14) UNIQUE
)

CREATE TABLE LogFuncionario(
    LogID INT IDENTITY PRIMARY KEY,
    FuncionarioID INT FOREIGN KEY REFERENCES Funcionario(FuncionarioID),
    Nome VARCHAR(100),
    DataCadastro DATETIME2(0) DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME())
    )

CREATE TRIGGER trg_LogFuncionario
ON Funcionario
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON
    INSERT INTO LogFuncionario(FuncionarioID, NOME)
    SELECT FuncionarioID, Nome FROM inserted
END

INSERT INTO Funcionario(Nome, CPF)
VALUES('Kessia', '434343433')

SELECT * FROM Funcionario
SELECT * FROM LogFuncionario


--Funcoes Textos

--Exercicio 1

SELECT CONCAT(Nome, ' ', Sobrenome) AS NomeCompleto FROM Cliente 

--Exercicio 2
SELECT UPPER(Nome) AS NomeMaiusculo FROM Produto

--Exercicio 3
SELECT SUBSTRING(Nome, 1, 3) FROM Cliente

--Exercicio 4
SELECT CHARINDEX('@', Email) FROM Cliente

--Funcoes Numericas

--Exercicio 1

SELECT * FROM Produto
    UPDATE Produto SET Preco = 70
    WHERE ProdutoID = 2 

--Exercicio 2