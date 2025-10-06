// FOR
// Contando de 1 a X
let x = parseInt(prompt("Digite um numero: "))

for(let i = 0; i <= x; i++)
{
    console.log(i);
}

// WHILE
// Fazer uma soma

let soma = 0;
let i = 1;
while(i <= 10)
{
    soma += i;
    console.log(soma);
    i++;
}
console.log("O resultado dos 10 numeros eh : " + soma)

//! DO/WHILE
// Garante a execucao do DO pelo menos uma vez

let numero = 1;

do{
    console.log("Numero: " + numero);
    numero ++;
}
while(numero <= 5)


//* FOREACH
// forEach faz uma funcao que executa um for para cada numero da array, apois isso usa variavel.forEach(fuction(novaVariavel))
let numeros = [1,2,3,4,5];

numeros.forEach(function(numeros){
    console.log("Numero do forEach: " + numeros);
})

let frutas = ["maca", "banana", "uva", "pera"]

frutas.forEach(function(fruta){
console.log(fruta);
})

for(let i =0; i < numeros.length; i++){
    console.log("Numero: " + numeros[i]);
}