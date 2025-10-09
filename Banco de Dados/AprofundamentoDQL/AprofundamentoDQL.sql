-- COUNT conta o total de registros
SELECT * FROM Leitor

SELECT COUNT(*) AS QtdLeitores
FROM Leitor;

SELECT * FROM Emprestimo;

SELECT l.nome, COUNT(e.id_emprestimo) AS QTDEmprestimo
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor = e.id_Leitor
--GROUP BY indica que o COUNT usado tem que se basear a partir desse atributo, logo: GROUP BY (atributo), vai mostrar 
--todos os emprestimos filtrados por nome
GROUP BY l.nome

-- MIN/MAX
SELECT Ano FROM Livro

--MIN menor
SELECT MIN(Ano) AS MenorAno FROM Livro;
--MAX maior
SELECT MAX(Ano) AS MaiorAno FROM Livro;

--FUNCOES DE TEXTO

--LEN eh usado para contar o numero de caracteres na string incluindo espaco
SELECT LEN('Kessia') AS TamanhoString
SELECT nome, LEN(nome) FROM Autor;

--UPPER (maiusculo) poe todas as strings em maiusculo / LOWER (minusculo) poe todas as strings em minusculo 
SELECT UPPER(nome) FROM Leitor
SELECT LOWER(nome) FROM Leitor

--LEFT / RIGHT
--Pega as letras a esuerda e direita
SELECT * FROM Livro

SELECT LEFT(titulo, 5) AS Primeiro5 FROM Livro
SELECT RIGHT(titulo,5) AS Ultimos5 FROM Livro

--REPLACE
--Trocar caracteres
SELECT * FROM Livro;

--REPLACE(nome.atributo, valorInicial, valorFinal)
--REPLACE nao altera o valor, somente na hora de vizualizacao
SELECT REPLACE(titulo, 'Harry', 'Hermione')
FROM Livro

--CHARINDEX
--Localizar a posicao de alguma palavra, caso nao tenha sera igual a 0
SELECT titulo, CHARINDEX('de', titulo) AS PocisaoTexto
FROM Livro

--CONCAT;
--Concatenar texto, fazendo com que fique em uma unica linha(atributo) apenas selecionado
SELECT CONCAT('Emprestimo ', e.id_Emprestimo, ' - Leitor: ', le.nome, ' - Livro: ', li.titulo)
FROM Emprestimo e
JOIN Leitor le ON le.id_Leitor = e.id_Leitor
JOIN Livro li ON li.id_Livro = e.id_Livro


--SUBSTRING
--Mostra o texto conforme o tamanho passado
--SUBSTRING(atributo, posicaoInicial, posicaoFinal)
SELECT SUBSTRING(titulo, 2, 10)
FROM Livro

-- RTRIM(direita) / LTRIM(esquerda) / TRIM(ambos os lados)
SELECT Nome, RTRIM(nome), LTRIM(nome), TRIM(nome)
FROM Leitor

--Funcoes de DATA e HORA

--GETDATE
--dia e horario atual da regiao atual
SELECT GETDATE()

--Dia e o horaria da zona querida
SELECT SYSDATETIMEOFFSET()
AT TIME ZONE 'E. South America Standart Time';

--DATEADD
--Adiciona um tempo a mais dentro de uma data
--YEAR, MONTH, WEEK, DAY
SELECT id_Emprestimo, data_emprestimo, DATEADD(MONTH, 7, data_emprestimo) AS PrevisaoDevolucao
FROM Emprestimo

--Diminuir tempo
SELECT id_Emprestimo, data_emprestimo, DATEADD(DAY, -7, data_emprestimo) AS PrevisaoDevolucao
FROM Emprestimo

--DATEDIFF: diferenca entre datas
SELECT id_emprestimo, data_emprestimo, data_devolucao,
--CASO a data_devolucao for nulo, adicionara a data de hoje e depois ira comparar a data atual com o emprestimo
DATEDIFF(DAY, data_emprestimo, ISNULL(data_devolucao, GETDATE()))
AS DiasComLivro
FROM Emprestimo

--FORMAT: FORMATAR DATAS
SELECT * FROM Emprestimo

SELECT FORMAT(data_emprestimo, 'dd/MM/yyyy') AS Emprestimo,
FORMAT(data_devolucao, 'dd/MM/yy') AS Devolucao
FROM Emprestimo

-- Extrair ano, mes e dia de uma data:
SELECT data_emprestimo,
YEAR(data_emprestimo) AS Ano,
MONTH(data_emprestimo) AS Mes,
DAY(data_emprestimo) AS Dia
FROM Emprestimo

--SET LANGUAFE muda a lingua que o computador vai entregar ao usuario
SET LANGUAGE Portuguese;

--DATEPART / DATENAME
--DATEPART pega o numero da semana, mes, ano
--DATENAME pega o nome da semana
SELECT DATEPART(YEAR, data_emprestimo) AS Ano,
DATEPART(WEEKDAY, data_emprestimo) AS DiaSemana,
DATENAME(WEEKDAY, data_emprestimo) AS NomeDiaSemana,
DATENAME(MONTH, data_emprestimo) AS NomeMes
FROM Emprestimo

SET LANGUAGE English

-- OPERADORES DE COMPARACAO
--(Igualdade) =
SELECT titulo, ano
FROM Livro
WHERE Ano = 2000

SELECT titulo
FROM Livro
-- Porcentagem indica que tenha mais conteudo alem do imposto, ou seja, vai mostrar aquele que contenha 'O' independente da
--posicao, caso colocasse apenas antes, vai ser aqueles que terminam com 'O', caso seja depois, os que comecam com 'O'
WHERE titulo LIKE '%O%'

--(diferente) NOT LIKE
SELECT nome, email
FROM Leitor
-- Nao funciona != e <> nessa funcao pois eh uma string
WHERE email NOT LIKE 'kes%'

SELECT titulo, ano
FROM Livro
WHERE Ano != 2000

SELECT titulo, ano
FROM Livro
-- Geralmente em bancos sqls se usa <>
WHERE Ano <> 2000

-- (maior que) >
SELECT titulo, ano
FROM Livro
WHERE ano > 1900

-- (menor que) <
SELECT titulo, ano
FROM Livro
WHERE ano < 1900

--(maior ou igual) >=
SELECT id_emprestimo, data_emprestimo
FROM Emprestimo
WHERE data_emprestimo >= '2025-09-01'

--(menor ou igual) <=
SELECT id_emprestimo, data_emprestimo
FROM Emprestimo
WHERE data_emprestimo <= '2025-08-01'

--OPERADORES LOGICOS

--AND acrecenta mais uma condicao
SELECT Emprestimo.id_Emprestimo, Leitor.nome, Emprestimo.data_emprestimo, Emprestimo.data_devolucao
FROM Emprestimo
JOIN Leitor ON Leitor.id_Leitor = Emprestimo.id_Leitor
WHERE MONTH(Emprestimo.data_emprestimo) = 9
AND YEAR(Emprestimo.data_emprestimo) = 2025

SELECT * FROM Emprestimo

--OR
SELECT l.titulo, l.ano, a.nome
FROM Livro l
JOIN Autor a ON a.id_Autor = l.id_Autor
WHERE a.nome = 'Machado de Assis'
OR a.nome = 'Clarice Lispector'

--NOT (negacao)
--Vai pegar todos contando que nao seja SHAKESPEARE
SELECT l.titulo, l.ano, a.nome
FROM Livro l
JOIN Autor a ON a.id_Autor = l.id_Autor
WHERE NOT a.nome = 'Shakespeare'

--OPERADORES ESPECIAIS

--BETWEWN(entre)
--Busca os valores entre ele
SELECT titulo, ano
FROM Livro
WHERE ano BETWEEN 1900 AND 2000

--IN (verifica uma lista de valores)
--Vai pegar apenas os valores que foram impostos em IN
SELECT * FROM Autor
WHERE nome IN ('Machado de Assis', 'Shakespeare')

--IS NULL
--Retorna registros vazios
SELECT id_Emprestimo, id_Livro, data_emprestimo
FROM Emprestimo
WHERE data_devolucao IS NULL

-- IS NOT NULL
SELECT id_emprestimo, id_livro, data_emprestimo
FROM Emprestimo
WHERE data_devolucao IS NOT NULL