// // Variáveis

// // Declarando variável

// string nome = "Richard";
// Console.WriteLine($"Meu nome é {nome}");

// int idade = 93;
// Console.WriteLine($"Tenho {idade} de idade");

// Console.WriteLine($"A idade do " + nome + " é " + idade + " anos");

// Tipos de dados

// int quantidade = 10;
// double preco = 4.99D;
// float altura = 1.8F;
// bool careca = true;
// string texto = "Olá, mundo";
// char letra = 'C';

// Operador de atribuição

// int idade = 16;

// // Soma
// Console.WriteLine(4 + 4);

// // Subtração
// Console.WriteLine(10 - 8);

// // Multiplicação
// Console.WriteLine(26 * 26);

// // Divisão
// Console.WriteLine(66884 / 6993);

// // Modular
// Console.WriteLine(5 % 2);

// Operadores de comparação - resposta true ou false

// // Igual a
// Console.WriteLine(5 == 9);

// // Maior ou igual a
// Console.WriteLine(5 >= 4);

// // Menor ou igual a
// Console.WriteLine(4 <= 3);

// // Maior que
// Console.WriteLine(5 > 1);

// // Menor que 
// Console.WriteLine(5 < 2);

// // Diferente de
// Console.WriteLine(5 != 8);

// Operadores lógicos & tabela verdade

// // && : e
// // || : ou
// //  ! : negação

// // && : e
// Console.WriteLine(5 == 5 && 8 == 8);
// Console.WriteLine(5 == 5 && 8 == 9);
// Console.WriteLine(5 == 6 && 8 == 8);
// Console.WriteLine(5 == 6 && 8 == 9);

// // || : ou
// Console.WriteLine(2 == 2 || 3 == 3);
// Console.WriteLine(4 == 5 || 6 == 6);
// Console.WriteLine(5 == 5 || 7 == 8);
// Console.WriteLine(1 == 2 || 3 == 4);

// //  ! : negação
// Console.WriteLine(!(2 == 3));



// Crie um programa para calcular o IMC de um pessoa

// Entradas
string nome = "Jamal Fictício";
float peso = 108.2F;
float altura = 2.12F;

// Processamento
float imc = peso / ( altura * altura );


Console.WriteLine($"O IMC de {nome} é {Math.Round(imc,2)}");