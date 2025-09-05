//? BASICO
/*
//* Exercicio 1
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

//! Exercicio 1

let numeroPares;


//* Exercicio 2
let numeroSorteado = 67;
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
    console.log("Tempo: " + contagem);
    contagem -= 1;
}
*/
//? AVANCADO

//* Exercicio 1

let numeroInserido = parseInt(prompt("Insira um numero para saber a soma de suas casas decimais"));
let numeroDeCasas = 1;
let somaNumero = 0;

while(numeroInserido >= 1)
{
  numeroInserido /= 10;
  somaNumero += numeroDeCasas;
  console.log(somaNumero);
  numeroDeCasas += 1;
}

//* Exercicio 2

let fatorialUsuario = parseInt(prompt("Insira um numero para exibir seu fatorial"));
let fatorial = 1;
for( i = fatorialUsuario ; i >= 1; i--)
{
    fatorial *=  i;
}
 console.log(fatorial);

 //* Exercicio 3