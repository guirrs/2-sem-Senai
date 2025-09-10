//? BASICO
//* Exercicio 1
/*
for(i = 0; i<= 10; i++)
{
    console.log(i);
}

//* Exercicio 2
let numero = 7;
for(i = 1; i <=10; i++)
{
    numero *= i;
    console.log("A tabuada do numero inserido eh: " + numero);
    numero /= i;
}

//* Exercicio 3

let numeroUsuario = parseInt(prompt("Insira um valor: "));
let numeroSoma = 1;

for(i = 0; numeroSoma <= numeroUsuario; i++)
{
    console.log(numeroSoma);
    numeroSoma += i;
}

//? INTERMEDIARIO

//* Exercicio 1

let numeroPares = 1;
console.log(numeroPares);
numeroPares = 2;
while(numeroPares <= 50)
{
    console.log(numeroPares);
    numeroPares += 2;
}

//* Exercicio 2
//Math.floor arredonda
//Math.randowm = gera um numero aleatorio de 0 a 1 (sem incluir o 1)
let numeroSorteado = Math.floor(Math.random() * 100);
let numeroAdivinhado = parseInt(prompt("Adivinhe o numero sorteado: "))

while(numeroSorteado != numeroAdivinhado )
{
    if(numeroAdivinhado < numeroSorteado)
        alert("O numero eh menor")
    else
    alert("O numero eh maior")

    numeroAdivinhado = parseFloat(prompt("Insira um novo valor: "));
}
alert("Parabens voce acertou")

//* Exercicio 3

contagem = parseInt(prompt("Escolhe o tempo da contagem regressiva"))

while(contagem >= 0)
{
    console.log("Tempo: " + --contagem);
}

//? AVANCADO

//* Exercicio 1

let numeroInserido = prompt("Insira um numero para saber a soma de suas casas decimais");
let numerosCasas = numeroInserido.length;
let somaNumeros = 0;

for(let i = 0; i < numerosCasas; i++)
{
   somaNumeros += parseInt(numeroInserido[i]);
}
console.log(somaNumeros);

//* Exercicio 2

let fatorialUsuario = parseInt(prompt("Insira um numero para exibir seu fatorial"));
let fatorial = 1;
for( i = fatorialUsuario ; i >= 1; i--)
{
    fatorial *=  i;
}
 console.log(fatorial);

 //* Exercicio 3

 let inverteNumeros = prompt("Insira um numero para ser invertido");
 let numerosPresentes = inverteNumeros.length - 1;
 let numeroInvertido = "";

 while(numerosPresentes >= 0)
 {
    numeroInvertido += inverteNumeros[numerosPresentes]
    numerosPresentes--;
 }
console.log(numeroInvertido);

//* Exercicio 4
*/
let numeroInseridoPer = parseInt(prompt("Insira uma numero para ver se ele eh perfeit0"))
let somaPer = 0;
let divisores = 0;

for(let i = 0; i <= numeroInseridoPer; i++ )
{
    if(i % numeroInseridoPer == 0)
        divisores += i;

    if(divisores == numeroInseridoPer)
        console.log("")
    
}
console.log();

if(somaPer == numeroInseridoPer)
    console.log("Numero eh perfeito")
else
    console.log("Nao eh perfeito")


//* DESAFIO

let somaPerfeita = 0;
let arrayPerfeitos = [];

for(let n = 0; n <= 1000; n++)
{

    for(let i = 0; somaPerfeita <= n - 1; i++)
        {
            somaPerfeita += i
        }
        
    if(somaPerfeita == n)
    {
        arrayPerfeitos.push(n);
    }
    somaPerfeita = 0;
}

console.log(arrayPerfeitos);