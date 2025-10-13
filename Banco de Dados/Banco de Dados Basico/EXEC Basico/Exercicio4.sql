CREATE DATABASE Restaurante

USE Restaurante

CREATE TABLE Pedido(
IdProduto INT PRIMARY KEY,
Cliente NVARCHAR(100),
Produto NVARCHAR(100),
Quantidade INT
)

INSERT INTO Pedido
VALUES
(1, 'Lorena', 'Batata', 23),
(2, 'Kauany', 'Pizza Mostruosa', 8),
(3, 'Fernando', 'Pizza Portuguesa', 2),
(4, 'Sandra', 'X-Bomba', 3),
(5, 'Gustavo', 'Camarao à Passarinho', 1),
(6, 'Gabriel', 'Pizza Calabresa', 14)

SELECT * FROM Pedido
WHERE Cliente = 'Gustavo'

SELECT * FROM Pedido
WHERE Produto LIKE 'Pizza%'

SELECT Cliente, Produto, Quantidade FROM Pedido
