//console.log("Hello World");

//? let ou var eh como declaramos a variaveis
//? o problema do var eh que ele menos eficiente e ele nao pode ser declarado dps da funcao onde eh usado, ele da indefinido, ja o let, ele alerta o erro
let variavel = "1";
//? const eh um valor que nao pode ser alterado
const menssage1 = "Hello World";

//? console.log() envia o que esta dentro do parenteses para o console do site, como se fosse o Serial do microcontrolador
console.log(menssage1);

//? == eh se eh igual, === eh para ver ser eh igual e o tipo dela
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
console.log(typeof (NaN));

console.log([] + {});

console.log([] == false);
console.log([] === false);

let variavelA = 10;
let variavelB = 20;

if (variavelA < variavelB) {
    console.log("VariavelA eh menor que variavelB");
}

let nome1 = "Guinas";
let idade = 17;

console.log("Ola, meu nome eh " + nome1 + " e tenho " + idade + " anos");

//? ``(acentos) permite voce incerir outras variaveis dentro da variavel, com ela estando em ${}
let menssage2 = `Ola, meu nome eh ${nome1}`

//? Alert eh um alerta que aparece na parte superior da pagina, que so aparecera o resto js depois que ele for respondido
//alert(menssage2);

let profissao;
//? typeof permite saber que tipo de variavel eh o elemento
console.log(typeof menssage2);
//? como nao ah nada declarado, vai ser indefinido, toda vez que houver indefinido, quer dizer que nada foi declarado
console.log(typeof profissao);


//* IF/ELSE IF/ELSE

let temperatura = 52;
if (temperatura >= 25 && temperatura < 45) {
    console.log("Esta calor!");
}

else if (temperatura < 25) {
    console.log("Esta frio!");
}

else {
    console.log("Nossa morte eh eminente");
}
let nome2 = prompt("Digite seu nome: ");

alert("Seu nome eh: " + nome2);

//* IF TERNARIO
let saldo = 120;
let cartaoPresente = true;

//? O ? eh o IF e o : eh o ELSE 
let podeComprar = (saldo >= 100 && cartaoPresente == true) ? "Compra aprovada!" : "Saldo insuficiente";
console.log(podeComprar);

//* SWITCH CASE
let dia = 2;

switch (dia) {
    case 1:
        console.log("Domingo")
        break;
    case 2:
        console.log("Segunda")
        break;
    case 3:
        console.log("Terca")
        break;
    case 4:
        console.log("Quarta")
        break;
    case 5:
        console.log("Quinta")
        break;
    case 6:
        console.log("Sexta")
        break;
    case 7:
        console.log("Sabado")
        break;

    default:
        console.log("Dia Invalido!")
}*/
