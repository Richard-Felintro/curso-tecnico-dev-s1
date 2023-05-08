using MaquinaDeCafe;

Console.Clear();
MaquinaCafe cafeteira = new MaquinaCafe();
Console.Write($"Informe a capacidade acúcar da cafeteira em gramas...");
cafeteira.acucarMaximo = float.Parse(Console.ReadLine()!);

cafeteiraLoop:
cafeteira.Tabajaras(cafeteira);
Console.WriteLine($" [1] Fazer um café");
Console.WriteLine($" [2] Reabastecer o açucar");
Console.WriteLine();
Console.WriteLine($"[0] Desligar a cafeteira");
string cafeteiraInput = Console.ReadLine()!;
switch (cafeteiraInput)
{
    case "1":
        cafeteira.Tabajaras(cafeteira);
        Console.WriteLine($"Deseja informar a quantia de açucar a ser adicionado...");
        Console.WriteLine($"[1] Sim");
        Console.WriteLine($"[2] Não");
        string SimOuNao = Console.ReadLine()!;
        switch (SimOuNao)
        {
            case "1":
                Console.Write($"Informe a quantia de gramas de açucar a ser adicionado...");
                float acucarInput = float.Parse(Console.ReadLine()!);
                cafeteira.FazerCafe(acucarInput);
                break;
            case "2":
                cafeteira.FazerCafe();
                break;
            default:
                break;
        }
        break;
    case "2":
        cafeteira.Tabajaras(cafeteira);
        float disperdicio = cafeteira.Abastecer();
        Console.Clear();
        if (disperdicio > 0)
        {
            Console.WriteLine($"Açucar adicionado com sucesso e {disperdicio}g de dispedício");
        }
        else
        {
            Console.WriteLine($"Açucar adicionado com sucesso");
        }
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        break;
    case "0":
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Super Cafeteira Tabajaras Plus ++");
        Console.ResetColor();
        Console.WriteLine($"Obrigado por usar Tabajaras inc...");
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        Environment.Exit(0);
        break;
}
goto cafeteiraLoop;