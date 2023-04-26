using Celular_POO;
Celular cell = new Celular();

//*Tela de design do celular
Console.Clear();
Console.WriteLine($"Bem-vindo ao Mercado Li-[Nome redactado de acordo com a Lei 9610, artigo 5, inciso I do código penal brasileiro]");
Console.WriteLine($"Escolha os parametros do seu novo celular!");
Console.WriteLine();
Console.Write($"Escolha um modelo... ");
cell.modelo = Console.ReadLine();
Console.WriteLine();
Console.Write($"Escolha o tamanho (polegadas)... ");
cell.tamanho = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Escolha a cor do celular...");
cell.cor = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Celular criado com sucesso!");
Console.Write($"Aperte ENTER para continuar...");
Console.ReadLine();
Console.Clear();
cell.ligado = false;

loopInfinito:
//*Tela de uso do celular
while (cell.ligado == false)
{
    Console.WriteLine($"[1] Ligar celular");
    Console.WriteLine($"[0] Guardar celular");
    string desligadoInput = Console.ReadLine()!;
    switch (desligadoInput)
    {
        case "1":
            cell.Ligar();
            break;
        case "0":
            Console.Clear();
            Environment.Exit(0);
            break;
        default:
            Console.Clear();
            break;
    }
}

//* Tela de uso do celular ligado
while (cell.ligado == true)
{
    Console.Clear();
    Console.WriteLine($"{(cell.modelo!.ToUpper())}");
    Console.WriteLine();
    Console.WriteLine("[1] Enviar mensagem");
    Console.WriteLine("[2] Fazer ligação");
    Console.WriteLine();
    Console.WriteLine("[0] Desligar");
string ligadoInput = Console.ReadLine()!;
switch (ligadoInput)
{
    case "1":
        cell.EnviarMensagem();
        break;
    case "2":
        cell.FazerLigacao();
        break;
    case "0":
        cell.Desligar();
        break;
}
}
goto loopInfinito;