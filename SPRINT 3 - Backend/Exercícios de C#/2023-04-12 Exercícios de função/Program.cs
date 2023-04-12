bool continuar = true;
Console.WriteLine($@"
 ________  ________  ___       ________  ___  ___  ___       ________  ________  ________  ________  ________     
|\   ____\|\   __  \|\  \     |\   ____\|\  \|\  \|\  \     |\   __  \|\   ___ \|\   __  \|\   __  \|\   __  \    
\ \  \___|\ \  \|\  \ \  \    \ \  \___|\ \  \\\  \ \  \    \ \  \|\  \ \  \_|\ \ \  \|\  \ \  \|\  \ \  \|\  \   
 \ \  \    \ \   __  \ \  \    \ \  \    \ \  \\\  \ \  \    \ \   __  \ \  \ \\ \ \  \\\  \ \   _  _\ \   __  \  
  \ \  \____\ \  \ \  \ \  \____\ \  \____\ \  \\\  \ \  \____\ \  \ \  \ \  \_\\ \ \  \\\  \ \  \\  \\ \  \ \  \ 
   \ \_______\ \__\ \__\ \_______\ \_______\ \_______\ \_______\ \__\ \__\ \_______\ \_______\ \__\\ _\\ \__\ \__\
    \|_______|\|__|\|__|\|_______|\|_______|\|_______|\|_______|\|__|\|__|\|_______|\|_______|\|__|\|__|\|__|\|__|");
while (continuar == true)
{
operacao:
    Console.WriteLine($@"
o----------+o+----------o
| Escolha sua operação: |
| [+] Adição            |
+ [-] Subtração         +
| [*] Multiplicação     |
| [/] Divisão           |
o----------+o+----------o");
string operacao = Console.ReadLine();
switch (operacao)
{
    case "+":
        break;
    case "-":
        break;
    case "/":
        break;
    case "*":
        break;
}


Console.WriteLine($"Informe o primeiro número:");
float numero1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe o segundo número:");
float numero2 = float.Parse(Console.ReadLine());

static float operacao

}

// static float operacao ()

//     switch (operacao)
//     {
//         case "+":
//             break;
//         case "-":
//             break;
//         case "/":
//             break;
//         case "*":
//             break;
//     }
// }
}