//? BASICO

console.log("Basico");       

//* EXERCICIO 1
console.log("exercicio 1:")
let idade1 = 16;
if (idade1 >= 18)
    console.log("Acesso confimado");
else
    console.log("Acesso negado");

//* Exerciocio 2
console.log("exercicio 2:")
let numero1 = -2;
if (numero1 >= 0)
    console.log("Positivo")
else
    console.log("Negativo");

//* Exercicio 3
console.log("exercicio 3:")
let nota = 75;
if (nota >= 60)
    console.log("Aprovado")
else
    console.log("Reprovado");

//* Exercicio 4
console.log("exercicio 4:")
let numero2 = 0;
if (numero2 > 0)
    console.log("Positivo")
else if (numero2 == 0)
    console.log("Zero")
else
    console.log("Negativo");

//*Exercicio 5
console.log("exercicio 5:")

let idade2 = 16;
if (idade2 >= 18)
    console.log("Adultp");
else if (idade2 > 13 && idade2 < 17)
    console.log("Adolecente");
else
    console.log("Crianca");

//* Exercicio 6
console.log("exercicio 6:")

let numero3 = 17;

if (numero3 % 2 == 0)
    console.log("Par");
else
    console.log("Impar");

//? INTERMEDIARIO 

console.log("Intermediario");

//* Exercicio 1

console.log("exercicio 1:")

let valor1 = prompt("Primeiro valor: ");
let operacao = prompt("Operacao: ");
let valor2 = prompt("Segundo valor: ")

if (valor2 != String && valor1 != String) {
    if (operacao == "+") {
        valor1 += valor2;
    }

    else if (operacao == "-") {
        valor1 -= valor2;
    }
    else if (operacao == "/") {
        valor1 /= valor2;
    }
    else if (operacao == "*") {
        valor1 *= valor2;
    }
    else {
        valor1 = "Valores Invalidos";
    }

    alert(`Resultado: ${valor1}`);
}

else {
    console.log("Valores Invalidos");
}

//*Exercicio 2

console.log("exercicio 2:")

let sequencia1 = prompt("Ensira o primeiro numero: ");
let sequencia2 = prompt("Ensira o segundo numero: ");
let sequencia3 = prompt("Ensira o terceiro numero: ");

if (sequencia1 > sequencia2 && sequencia1 > sequencia3)
    console.log("O primeiro valor eh maior");
else if (sequencia2 > sequencia1 && sequencia2 > sequencia3)
    console.log("O segundo valor eh maior");
else
    console.log("O terceiro valor eh maior");


//* Exercicio 3

console.log("exercicio 3:")

valorCompra = prompt("Ensira o valor de compra");

if (valorCompra >= 100) {
    valorCompra *= 0.9;
    console.log(`Desconto aplicado: ${valorCompra}`);
}

else
    console.log(`Desconto nao aplicado: ${valorCompra}`);

//* Exercicio 4

console.log("exercicio 1:")

let usuario = prompt("Usuario: ");
let senha = prompt("Senha: ");

let acesso = (usuario == "admin" && senha == "1234") ? console.log("Login Bem sucedido") : console.log("Acesso negado");

//? AVANCADO

console.log("Avancado");    

//* Exercicio 1

console.log("exercicio 2:")

lado1 = prompt("Insira a medida do primeiro lado: ");
lado2 = prompt("Insira a medida do segundo lado: ");
lado3 = prompt("Insira a medida do terceiro lado: ");

if (lado1 == lado2 && lado2 == lado3 && lado1 == lado3) {
    console.log("Triangulo equilatero");
}

else if (lado1 == lado2 && lado3 > lado2) {
    console.log("Triangulo isoceles")
}
else if (lado3 == lado2 && lado1 > lado2) {
    console.log("Triangulo isoceles")
}
else if (lado3 == lado1 && lado2 > lado1) {
    console.log("Triangulo isoceles")
}

else
    console.log("Triangulo escaleno")

//* Exercicio 2

console.log("exercicio 3:")

let nota2 = prompt("Nota da prova: ");

if (nota2 > 100)
    nota2 = 100;

if (nota2 > 90)
    console.log("Nota A");
else if (nota2 >= 80 && nota2 < 90)
    console.log("Nota B");
else if (nota2 >= 70 && nota2 < 79)
    console.log("Nota C");
else if (nota2 >= 60 && nota2< 69)
    console.log("Nota D");
else if (nota2 < 60)
    console.log("Nota F");


//* Exercicio 4

console.log("exercicio 4:")

let anoAtual = 2025;

if(anoAtual % 4 == 0 && anoAtual % 100 != 0)
    console.log("ANO BISSEXTO");
else
    console.log("Nao eh bissexto ;-;");
