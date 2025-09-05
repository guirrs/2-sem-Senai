//? BASICO

console.log("BASICO");

//* EXERCICIO 1

console.log("Exercicio 1");

let idade1 = prompt("Digite sua idade");
// parseInt() transforma a variavel em int
idade1 = parseInt(idade1);

if(idade1 >= 18)
    console.log("Acesso confimado");
else
console.log("Acesso negado");

//* Exerciocio 2

console.log("Exercicio 2");

let numero1 = prompt("Digite um numero para verificar se eh positivo ou negativo");
numero1 = parseInt(numero1);

if(numero1 >= 0)
    console.log("Positivo");
else
    console.log("Negativo");

//* Exercicio 3

console.log("Exercicio 3");

let nota = prompt("Digite sua nota para saber se reprovou ou foi aprovado");
nota = parseInt(nota)


if(nota >= 60)
    console.log("Aprovado");
else
    console.log("Reprovado");

//* Exercicio 4

console.log("Exercicio 4");

let numero2 = prompt("Digite um numero para verificar se eh positivo ou negativo ou zero")
numero2 = parseInt(numero2);

if(numero2 > 0)
    console.log("Positivo");
else if( numero2 == 0)
    console.log("Zero");
else
    console.log("Negativo");

//*Exercicio 5

console.log("Exercicio 5");

let idade2 = prompt("Verifique sua faxetaria, quantos anos voce tem?");
idade2 = parseInt(idade2);

if(idade2 >= 18)
    console.log("Adulto");
else if(idade2 > 12 && idade2 < 18)
    console.log("Adolecente");
else
console.log("Crianca");

//* Exercicio 6

console.log("Exercicio 6");

let numero3 = prompt("Digite um numero para verificar se eh par ou impar");
numero3 = parseInt(numero3);

if(numero3 % 2 == 0)
    console.log("Par");
else
    console.log("Impar");

//? INTERMEDIARIO 

console.log("INTERMEDIARIO");

//* Exercicio 1

console.log("Exercicio 1");

let valor1 = prompt("Primeiro valor: ");
valor1 = parseInt(valor1)
let operacao = prompt("Operacao: ");
let valor2 = prompt("Segundo valor: ")
valor2 = parseInt(valor2)

if(valor2 != String && valor1 != String)
{
    if(operacao == "+")
    {
    valor1 += valor2;
    }

    else if(operacao == "-")
    {
        valor1 -= valor2;
    }
    else if(operacao == "/" || operacao == "")
    {
        valor1 /= valor2;
    }
    else if(operacao == "*" || operacao == "x")
    {
        valor1 *= valor2;
    }
    else{
        valor1 = "Valores Invalidos";
    }

    alert(`Resultado: ${valor1}`);
}

else{
    console.log("Valores Invalidos");
}

//*Exercicio 2

console.log("Exercicio 2");

let sequencia1 = prompt("Ensira o primeiro numero: ");
let sequencia2 = prompt("Ensira o segundo numero: ");
let sequencia3 = prompt("Ensira o terceiro numero: ");

sequencia1 = parseInt(sequencia1)
sequencia2 = parseInt(sequencia2)
sequencia3 = parseInt(sequencia3)

if(sequencia1 >= sequencia2 && sequencia1 >= sequencia3)
    console.log("O primeiro valor eh maior");
else if(sequencia2 > sequencia3)
    console.log("O segundo valor eh maior");
else
    console.log("O terceiro valor eh maior");


//* Exercicio 3

console.log("Exercicio 3");

valorCompra = prompt("Ensira o valor de compra");
valorCompra = parseInt(valorCompra)

if(valorCompra >= 100)
{
    valorCompra *= 0.9;
    console.log(`Desconto aplicado: ${valorCompra}`);
}

else
 console.log(`Desconto nao aplicado: ${valorCompra}`);

 //* Exercicio 4

 console.log("Exercicio 4");

 let usuario = prompt("Usuario: ");
 let senha = prompt("Senha: ");

 let acesso = (usuario ==  "admin" && senha == "1234") ? console.log("Login Bem sucedido") : console.log("Acesso negado");

 //? AVANCADO

 console.log("AVANCADO");

 //* Exercicio 1

 console.log("Exercicio 1");

 lado1 = prompt("Insira a medida do primeiro lado do triangulo: ");
 lado1 = parseInt(lado1)
 lado2 = prompt("Insira a medida do segundo lado triangulo: ");
 lado2 = parseInt(lado2)
 lado3 = prompt("Insira a medida do terceiro lado triangulo: ");
 lado3 = parseInt(lado3)

 if(lado1 + lado2 >= lado3 || lado2 + lado3 >= lado1 || lado1 + lado3 >= lado2)
    console.log("Nao eh um triangulo")

 else if(lado1 == lado2 && lado2 == lado3)
    console.log("Triangulo equilatero");

 else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    console.log("Triangulo isoceles");

 else
  console.log("Triangulo escaleno")

//* Exercicio 2

console.log("Exercicio 2");

let nota2 = prompt("Digite sua nota: ")
nota2 = parseInt(nota2)

if(nota2 > 100 || nota2 < 0)
{
    console.log("Digite uma nota valida")
    nota2 = prompt("Digite sua nota")
}

else if(nota2>90)
    console.log("Nota: A");
else if(nota2>80 && nota2<90)
    console.log("Nota: B");
else if(nota2>70 && nota2<80)
    console.log("Nota: C");
else if(nota2<60 && nota2>70)
    console.log("Nota: D");
else if(nota2<60)
    console.log("Nota: F");

//* Exercicio 3

console.log("Exercicio 3");

let peso = prompt("Digite seu peso");
peso = parseInt(peso);
let altura = prompt("Digite sua altura");
altura = parseInt(altura);

let calculo = (peso / (altura * altura))

if(calculo > 30)
    console.log("Obeso");
else if(calculo > 24.9 && calculo < 30)
    console.log("Sobrepeso");
else if(calculo < 24.9 && calculo > 18.5)
    console.log("Peso normal");
else if(calculo < 18.5)
    console.log("Abaixo do peso");

//* Exercicio 4

console.log("Exercicio 4");

let ano = 2025

if((!Boolean(ano % 4)  && Boolean(ano % 100)) || !Boolean(ano % 400))
    console.log("Ano eh " + ano+  " bissexto")
else
    console.log("Ano " + ano + " nao eh bissexto")