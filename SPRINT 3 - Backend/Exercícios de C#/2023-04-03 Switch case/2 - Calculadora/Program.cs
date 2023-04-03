// calculadora

// Algoritmo

// 1. Informar o primeiro número
// 2. Informar o segundo número
// 3. Informar o terceiro número
// 4. Processar os dados
// 5. Exibir o resultado

// Entrada

Console.WriteLine($@"
 ________  ________  ___       ________  ___  ___  ___       ________  ________  ________  ________  ________     
|\   ____\|\   __  \|\  \     |\   ____\|\  \|\  \|\  \     |\   __  \|\   ___ \|\   __  \|\   __  \|\   __  \    
\ \  \___|\ \  \|\  \ \  \    \ \  \___|\ \  \\\  \ \  \    \ \  \|\  \ \  \_|\ \ \  \|\  \ \  \|\  \ \  \|\  \   
 \ \  \    \ \   __  \ \  \    \ \  \    \ \  \\\  \ \  \    \ \   __  \ \  \ \\ \ \  \\\  \ \   _  _\ \   __  \  
  \ \  \____\ \  \ \  \ \  \____\ \  \____\ \  \\\  \ \  \____\ \  \ \  \ \  \_\\ \ \  \\\  \ \  \\  \\ \  \ \  \ 
   \ \_______\ \__\ \__\ \_______\ \_______\ \_______\ \_______\ \__\ \__\ \_______\ \_______\ \__\\ _\\ \__\ \__\
    \|_______|\|__|\|__|\|_______|\|_______|\|_______|\|_______|\|__|\|__|\|_______|\|_______|\|__|\|__|\|__|\|__|
o--+----+----+-<>-+----+----+--o                     ________  ___  ________  ___  ___  ________  ________  ________
|      Informe a operação      |                    |\   __  \|\  \|\   ____\|\  \|\  \|\   __  \|\   __  \|\   ___ \
|  [+] Adição                  |                    \ \  \|\  \ \  \ \  \___|\ \  \\\  \ \  \|\  \ \  \|\  \ \  \_|\ \
|  [-] Subtração               |                     \ \   _  _\ \  \ \  \    \ \   __  \ \   __  \ \   _  _\ \  \ \\ \
|  [*] Multiplicação           |                      \ \  \\  \\ \  \ \  \____\ \  \ \  \ \  \ \  \ \  \\  \\ \  \_\\ \
|  [/] Divisão                 |                       \ \__\\ _\\ \__\ \_______\ \__\ \__\ \__\ \__\ \__\\ _\\ \_______\
o--+----+----+-<>-+----+----+--o                        \|__|\|__|\|__|\|_______|\|__|\|__|\|__|\|__|\|__|\|__|\|_______|
");
// Em string pq o cliente pode ser burro e mandar uma frase inteira
string operacao = (Console.ReadLine());

Console.WriteLine($"Informe o primeiro número:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número:");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0;

switch (operacao)
{
    case "+":
    resultado = num1 + num2;
    break;
    case "-":
    resultado = num1 - num2;
    break;
    case "*":
    resultado = num1 * num2;
    break;
    case "/":
    resultado = num1 / num2;
    break;
    default:
    Console.WriteLine($"Valor inválido");
    break;
} 
Console.WriteLine($"{resultado}");