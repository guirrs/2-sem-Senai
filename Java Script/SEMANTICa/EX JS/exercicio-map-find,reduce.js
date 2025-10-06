//? FILTER
console.log("FILTER")

//* Exercicio 1
const notas = [4,7,9,3,10,5];

let maiores7 = notas.filter(nota => nota > 7)
console.log(`${maiores7} sao as notas maiores que 7`);

//* Exercicio 2
const palavras = ["sol", "mar", "computador", "lua", "codigo"];

let palavras4 = palavras.filter(palavra => palavra.length >= 4)
console.log(`${palavras4} sao as palavras que contem mais de 4 letras`)

//* Exercicio 3
const animais = ["gato", "cachorro", "peixe", "elefante", "abelha"];

let animaisC = animais.filter(animal => animal.startsWith("c"))
console.log(`${animaisC} eh o animal que comeca com C`);

//? FIND
console.log("FIND")

//* Exercicio 1
const filmes = ["Avatar", "Batmam", "Vingadores", "Matrix", "Barbie"];
let filmesB = filmes.find(filme => filme.startsWith("B"));
console.log(`${filmesB} eh o primeiro filme que comeca com B `);

//*Exercicio 2
const numeros = [2,4,6,9,12,15];

let numeroImpar = numeros.find(numero => numero % 2 != 0)
console.log(`${numeroImpar} eh o primeiro numero impar`)

//* Exercicio 3
const alunos = [
    {nome: "Ana", nota: 8}, 
    {nome: "Carlos", nota: 5}, 
    {nome: "Beatriz", nota: 9}];

let aluno7 = alunos.find(aluno => aluno.nota >= 7)
console.log(`O Primeiro aluno a tirar acima de 7 eh ${aluno7}`);

//? MAP
console.log("MAP")

//* Exercicio 1

const temperaturas = [20, 25, 30, 15];

temperaturasFr = temperaturas.map(temperatura => temperatura * 1.8 + 32)
console.log(`Temperatura em Fahrenheit eh ${temperaturasFr}`);

//* Exercicio 2

const produtos = ["camisa", "calça", "sapato"];

produtosMais = produtos.map(produto => `Produtos:${produto.toUpperCase()} `)
console.log(`Proudto: ${produtosMais}`)

//* Exercicos 3
const numeros2 = [1, 2, 3, 4];

let numeroQuadrado = numeros2.map(numero => numero * numero)
console.log(numeroQuadrado);

//? REDUCE
console.log("REDUCE")

//* Exercico 1
const valores = [100, 200, 50, 150];

let soma = valores.reduce((somaT, valor) => somaT + valor, 0)
console.log(soma)

//* Exercicio 2
const palavras2 = ["JS", "é", "muito", "legal"];

let juncao = palavras2.reduce((juntas, palavra) => juntas + " " + palavra,"")
console.log(juncao);

//* Exercicio 3
const numeros3 = [1, 2, 3, 4, 5];

media = numeros3.reduce((total, numero) => (total + numero), 0)/ numeros3.length;
console.log(media);

//? DESAFIO
console.log("DESAFIOS")

//* Exercicio 1
console.log("Desafio 1")
const livros = [
    { titulo: "Dom Casmurro", paginas: 300 },
    { titulo: "O Hobbit", paginas: 295 },
    { titulo: "A Revolução dos Bichos", paginas: 112 }
    ];

    let pag200 = livros.filter(livro => livro.paginas > 200);
    let titulo = livros.map(livro => livro.titulo);
    let somaPag = livros.reduce((soma, livro) => soma += livro.paginas, 0)
    
    console.log(pag200);
    console.log(titulo);
    console.log(somaPag);

//* Exercicio 2
console.log("Desafio 2")
const carrinho = [
    { produto: "Notebook", preco: 2500 },
    { produto: "Mouse", preco: 100 },
    { produto: "Teclado", preco: 200 }
  ];

  let valor = carrinho.map(carro => `Produto: ${carro.produto} - R$ ${carro.preco}`)
  let valorTotal = carrinho.reduce((somaTotal, carro) => somaTotal + carro.preco, 0)
  let acharMouse = carrinho.find(carro => carro.produto == "Mouse");

  console.log(valor)
  console.log(valorTotal)
  console.log(acharMouse)