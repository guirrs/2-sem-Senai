CREATE DATABASE Rede

USE Rede

CREATE TABLE Funcionario(
IdFuncionario INT PRIMARY KEY,
Nome NVARCHAR(150),
Cargo NVARCHAR(100),
Salario DECIMAL(15)
)

INSERT INTO Funcionario(IdFuncionario, Nome, Cargo, Salario)
VALUES
(1, 'Kayo', 'Dev-Junior', 3220.83),
(2, 'Julio', 'MultiMidia', 2800.00),
(3, 'Afonso', 'Dev-Senior', 11343.27),
(4, 'Laura', 'Recepcionisya', 1900.00),
(5, 'Dhejifer', 'Manutencao Eletrica', 8234.87)

SELECT Nome, Salario FROM Funcionario
WHERE Salario >= 3000

SELECT * FROM Funcionario
WHERE Cargo LIKE 'Dev%'

SELECT Nome, Cargo From Funcionario