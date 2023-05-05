using ElevadorNS;
static void Menu(string menuMsg, string menuMsg2, bool menuEnter)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{menuMsg}");
    Console.ResetColor();
    Console.Write($"{menuMsg2}");
    if (menuEnter == true)
    {
        Console.ReadLine();
        Console.Clear();
    }
}
Elevador elevador = new Elevador();
Menu("Configure o elevador", "Informe a quantia de andares no prédio... ", false);
int andaresInput = int.Parse(Console.ReadLine()!);
Menu("Configure o elevador", "Informe a capacidade total do elevador... ", false);
int pessoasInput = int.Parse(Console.ReadLine()!);
Menu("Elevador inicializado com sucesso!", "Aperte ENTER para continuar...", true);
elevador.Inicializa(andaresInput, pessoasInput);
elevadorLoop:
Menu("Seu elevador está em operação, o que vai acontecer com ele?", " [1] Um funcionário entra no elevador... \n [2] Um funcionário sai do elevador... \n [3] O elevador sobe um andar... \n [4] O elevador desce um andar...\n\n [0] Sair do programa...\n", false);
Console.WriteLine($"Andar {elevador.andarAtual}/{elevador.andarMaximo} | Capacidade {elevador.pessoasAtual}/{elevador.pessoasMaximo}");
string menuInput = Console.ReadLine()!;
switch (menuInput)
{
    case "1":
        elevador.Entrar();
        break;
    case "2":
        elevador.Sair();
        break;
    case "3":
        elevador.Subir();
        break;
    case "4":
        elevador.Descer();
        break;
    case "0":
        Menu("Obrigado por utilizar este simulador de elevador!", "Aperte ENTER para continuar...", true);
        Environment.Exit(0);
        break;
    default:
        Menu("Valor informado inválido", "O valor {menuInput} Não é uma opção válida", true);
        break;
}
goto elevadorLoop;