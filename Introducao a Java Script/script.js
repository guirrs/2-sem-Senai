//console.log("Hello World");

// let ou var eh como declaramos a variaveis
// o problema do var eh que ele menos eficiente e ele nao pode ser declarado dps da funcao onde eh usado, ele da indefinido, ja o let, ele alerta o erro
const menssage = "Hello World";
let variavel = "1";

//== eh se eh igual, === eh para ver ser eh igual e o tipo dela
console.log(variavel === 1);

console.log(0 === false);

console.log("" == 0);
console.log("" == false);
console.log("" === 0);
console.log("1" == true);
console.log("3" == true);

console.log("1" + "banana");
console.log("1" - "banana");

console.log(NaN == NaN);
console.log(typeof(NaN));

console.log([] + {});

console.log([] == false);
console.log([] === false);

let variavelA = 10;
let variavelB = 20;

if(variavelA < variavelB)
{
    console.log("VariavelA eh menor que variavelB");
}
