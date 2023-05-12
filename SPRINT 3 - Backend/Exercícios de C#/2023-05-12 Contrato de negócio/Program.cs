using static System.Console;
static void MudarMenu(string x)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"CONTATOS");
    Console.ResetColor();
    Console.WriteLine($"{x}\n");
}

loopMenu:
MudarMenu("Menu principal");
Console.WriteLine($"[1] Adicionar Contato");
Console.WriteLine($"[2] Remover Contato");
Console.WriteLine($"[3] Listar Contatos\n");
Console.WriteLine($"[0] Sair");
string menuInput = Console.ReadLine();
switch (menuInput)
{
    case "1":
        break;
    case "2":
        break;
    case "3":
        break;
    case "0":
        MudarMenu("Fechando programa");
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
        Environment.Exit(1);
        break;
    default:
        break;
}

goto loopMenu;