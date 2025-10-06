//? FILTER

//* Filtrar numros maiores que 2
const numeros = [1,2,3,4,5,6];

// varivel => faz a mesma coisa que variavel.function
// variavel.filter eh um filtro na qual voce cria uma funcao para ele, logo, nao a necessidade de declarar a variavel dentro da funcao
const maioresQueDois = numeros.filter(numero => numero > 2)
console.log(maioresQueDois);

//* Filtrar nomes
let nomes = ["Ana", "Bruno", "Carlos", "Eva", "Fernanda"];

let nomesLongos = nomes.filter(nome => nome.length > 5)
console.log(nomesLongos);

//* Filtrar numeros pares
let conjNumeros = [1,2,3,4,5,6,7,8,9,10]

let pares = conjNumeros.filter(numero => numero % 2 === 0);
console.log(pares);

//* Filtrar um objeto

let pessoas = [
    // Dentro do objeto se usa : pois voce nao esta declarando variaveis, e sim indicando pares, entao NAO SE USA =
    //Dentro do objeto voce cria pares de chaves, se usa isso em banco de dados, nesse caso criar o par com : valor que indica e virgula para cotinuar
    {nome: "Lucas", idade: 17},
    {nome: "Mariana", idade: 22},
    {nome: "Ana Catarina", idade: 15},
    {nome: "Juliana", idade: 30}
]

let adultos = pessoas.filter(pessoa => pessoa.idade >= 18)
console.log(adultos);

//? FIND

//*FInd so se usa para desocobriri o primeiro valor, diferente do filter que sao todos

//* Procurar produtos pelo preco
const produtos = [
    {id: 1, nome: "Teclado", preco: 100},
    {id: 2, nome: "Mouse", preco: 50},
    {id: 3, nome: "Monitor", preco: 700},
]

const produtoCaro = produtos.find(produto => produto.preco > 600);
console.log(produtoCaro);

//* Encontrar o primeiro numero maior que 10

let numerosM10 = [5, 8, 12, 20, 3]

let encontrado = numerosM10.find(numero => numero > 10)
console.log(encontrado);

//* Buscar por um nome pela primeira letra
let nomesPL = ["Ana", "Bruna", "Afonso", "Kaio", "Rafael"]

let nomeEncontrado =  nomesPL.find(nome => nome.startsWith("R"));
console.log(nomeEncontrado);

//? MAP

//* O map verifica todos os valores da array

//* Multiplicar todos os numeros por 2
const numerosMulti = [1,2,3,4,5]

const numerosDobrados = numeros.map(numero => numero * 2)
console.log(numerosDobrados)

//* Criando array apartir de objeto

let pessoas2 = [
{nome: "Lucas", idade: 17},
{nome: "Mariana", idade: 22},
{nome: "Ana Catarina", idade: 15},
{nome: "Juliana", idade: 30}
]

let nomesMap = pessoas.map(pessoa => pessoa.nome)
console.log(nomesMap)

// use acentos e cifrao para por variavel dentro da mensagem
let mensagem = pessoas.map(pessoa => `${pessoa.nome} tem ${pessoa.idade} anos.`)

console.log(mensagem);

//* Deixar os nomes em maiusculo e adicionar um sufixo
const nomesAcrecentados = ["Ana", "Bruno", "Carla"]

const nomesMaiusculos = nomes.map(nome => "Colaborador: " + nome.toUpperCase())

console.log(nomesMaiusculos);

//? REDUCE

//* Reduz a array a um unico valor

//* Somar todos os numeros da array
const numerosRe = [1, 2, 3, 4, 5]
//O reduce precisa de uma acumalador que ira receber os valores e auxiliar para ser encaixado os numeros, depois da funcao, ponha virgular para declarar o valor do acumulador
const somaRe = numerosRe.reduce((acumulador, numero) => acumulador + numero, 0)

console.log(somaRe)

//* Verificar o maior numro do array
const numerosMNum = [10,5,8,20,30]

const maiorNumero = numerosMNum.reduce((max, numero) => {
    if(numero > max)
        return numero
    else
        return max 
    
}, numeros[0]
)
console.log(maiorNumero);


//* Contar a frequencia de palavras
const palavrasFre = ["maca", "banana", "laranja", "maca", "banana", "maca"]

const contagem = palavrasFre.reduce((acumulador, palavra) => {
    // em codicoes de true e false nao precisa de if
    //o acumalador vai ver palavra por palavra e vai identificar quantas vezes a palavra dentro dela foi repetida
    acumulador[palavra] = (acumulador[palavra] || 0) + 1
    return acumulador
    // a chave vazia para o acumulador ser vazio
}, {})

//*Calcular media de notas

const notas = [7,8,9,6,10]

const media = notas.reduce((total, nota) => total + nota, 0) / notas.length();

const usuarios2 = [
    {nome: "Lucas", idade: 17, id: 1},
    {nome: "Mariana", idade: 22, id: 2},
    {nome: "Ana Catarina", idade: 15, id: 3},
    ]

//FILTRAR USUSARIOS  com idade maior que 21
const maioresDeIdade = ususarios.filter(usuarios2 => usuarios2.idade > 21)

//* Encontrar o primeiro usuario com idade maior que 21
const ususarioIdade = usuarios.find(usuario2 => usuarios2.idade > 21)

//* Criar uma array apenas com nomes de usuarios 
const nomesUsuarios = usuarios2.map(usuario2 => usuario2.nome)

//* Somar todas as idades dos usuarios usando o reduce
const somaIdades = usuarios2.reduce((total, usuarios2) => total + usuarios2.idade, 0)

console.log(maioresDeIdade);
console.log(ususarioIdade);
console.log(nomesUsuarios);
console.log(somaIdades);