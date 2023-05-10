using GeradorDeCraques;

static void MudarMenu(string frase)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"!!! GERADOR DE CRAQUES 3000 !!!");
    Console.ResetColor();
    Console.WriteLine($"{frase}");
    Console.WriteLine();
}

static void ValorInvalido()
{
    MudarMenu("Erro! O valor informado não é uma opção válida");
    Console.Write($"Aperte ENTER para continuar...");
    Console.ReadLine();
}


List<JogadorFutebol> jogadores = new List<JogadorFutebol>();

loop:
MudarMenu("Menu principal");
Console.WriteLine($"[1] Adicionar jogador");
Console.WriteLine($"[2] Inspecionar jogadores");
Console.WriteLine();
Console.WriteLine($"[0] Sair do gerador");
string menuInput = Console.ReadLine();
switch (menuInput)
{
    case "1":
        MudarMenu("Informe o nome do Jogador...");
        string nomeInput = Console.ReadLine();
        MudarMenu("Informe a data de nascimento do Jogador...");
        DateTime dataInput = DateTime.Parse(Console.ReadLine());
        MudarMenu("Informe a nacionalidade do Jogador...");
        string nacionalidadeInput = Console.ReadLine();
        MudarMenu("Informe a altura do Jogador...");
        float alturaInput = float.Parse(Console.ReadLine());
        MudarMenu("Informe o peso do Jogador...");
        float pesoInput = float.Parse(Console.ReadLine());
        MudarMenu("Informe a posição do Jogador:");
        Console.WriteLine($"[1] Jogador de Ataque");
        Console.WriteLine($"[2] Jogador de Meio-campo");
        Console.WriteLine($"[3] Jogador de Defesa");
        string jogadorInput = Console.ReadLine();
        switch (jogadorInput)
        {
            case "1":
                jogadores.Add(new JogadorAtaque(nomeInput, dataInput, nacionalidadeInput, alturaInput, pesoInput));
                break;
            case "2":
                jogadores.Add(new JogadorMeiocampo(nomeInput, dataInput, nacionalidadeInput, alturaInput, pesoInput));
                break;
            case "3":
                jogadores.Add(new JogadorDefesa(nomeInput, dataInput, nacionalidadeInput, alturaInput, pesoInput));
                break;
            default:
                ValorInvalido();
                goto loop;
        }
        MudarMenu("Craque criado com sucesso!");
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        break;
    case "2":
        MudarMenu("Lista de jogadores:");
        foreach (var item in jogadores)
        {
            Console.WriteLine($"JOGADOR {item.Nome}");
            Console.WriteLine($"DATA DE NASCIMENTO {item.DataNascimento.Date.ToString()}");
            Console.WriteLine($"IDADE {item.Idade} anos");
            Console.WriteLine($"NACIONALIDADE {item.Nacionalidade}");
            Console.WriteLine($"ALTURA {item.Altura}m");
            Console.WriteLine($"PESO {item.Peso}kg");
            if (item.Aposentadoria > 0)
            {
                Console.WriteLine($"APOSENTADORIA MÉDIA em {item.Aposentadoria} anos");
            }
            else if (item.Aposentadoria < 0)
            {
                Console.WriteLine($"APOSENTADORIA MÉDIA {item.Aposentadoria * -1} anos atrás");
            }
            else
            {
                Console.WriteLine($"APOSENTADORIA MÉDIA neste ano");
            }
            Console.WriteLine();
        }
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        break;
    case "0":
        MudarMenu("Obrigado por usar o GERADOR DE CRAQUES 3000");
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        Environment.Exit(1);
        break;
    default:
        ValorInvalido();
        goto loop;
}
goto loop;