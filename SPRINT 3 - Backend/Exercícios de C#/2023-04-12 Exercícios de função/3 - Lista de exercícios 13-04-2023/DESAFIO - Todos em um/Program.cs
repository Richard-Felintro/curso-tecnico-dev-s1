Console.Clear();

// PROSSEGUIR //

static void Continuar(){
    Console.WriteLine($@"
    Pressione [enter] para continuar...");
    Console.ReadLine();
    Console.Clear();
}

// IDADE DE VOTO //

static void IdadeDeVoto()
{Console.Clear();
inicio:
    Console.WriteLine($"Informe seu ano de nascimento:");
    int anoNascimento = int.Parse(Console.ReadLine());
    if (anoNascimento > DateTime.Now.Year)
    {
        Console.WriteLine($"~+~+~ ANO DE NASCIMENTO INVÁLIDO ~+~+~");
        goto inicio;
    }
    if (DateTime.Now.Year - anoNascimento >= 16)
    {
        Console.WriteLine($"Você pode legalmente votar!");
    }
    else
    {
        Console.WriteLine($"Você não pode votar legalmente.");
    }
}

// CALCULADORA DE PREÇO DE GASOLINA //

static void CalculadoraGasolina()
{Console.Clear();
    float preco;
escolhaCompra:
    Console.WriteLine($@"Escolha o seu combustível:
[A] Álcool
[G] Gasolina");
    string escolhaCompra = Console.ReadLine().ToUpper();
    if (escolhaCompra != "A" && escolhaCompra != "G") { }
    else
    {
        Console.WriteLine($"~+~+~ ESCOLHA INVÁLIDA ~+~+~");
        goto escolhaCompra;
    }
    Console.WriteLine($"Informe quantos litros deseja comprar:");
    float litros = float.Parse(Console.ReadLine());
    if (escolhaCompra == "A")
    {
        if (litros <= 20)
        {
            preco = litros * 4.9F * 0.97F;
        }
        else
        {
            preco = litros * 4.9F * 0.95F;
        }
        Console.WriteLine($"O custo de {litros} de álcool será R${Math.Round(preco),2}");
    }
    else
                if (litros <= 20)
    {
        preco = litros * 5.3F * 0.96F;
    }
    else
    {
        preco = litros * 5.3F * 0.92F;
    }
    Console.WriteLine($"O custo de {litros} de gasolina será R${Math.Round(preco),2}");
}

// ANÁLISE DE PRODUTO E DESCONTO //
static void AnaliseProduto()
{Console.Clear();
    float desconto = 0;
    Console.WriteLine($"Informe o nome do produto:");
    string nomeProduto = Console.ReadLine();
    Console.WriteLine($"Informe quantas unidades deseja adiquirir:");
quantidade:
    int quantidade = int.Parse(Console.ReadLine());
    if (quantidade < 1)
    {
        Console.WriteLine($"~+~+~ QUANTIDADE INVÁLIDA ~+~+~");
        goto quantidade;
    }
    Console.WriteLine($"Informe o preço unitário do produto:");
    float precoUnitario = float.Parse(Console.ReadLine());
    if (quantidade <= 5)
    {
        desconto = 0.02F;
    }
    else if (quantidade > 5 && quantidade <= 10)
    {
        desconto = 0.03F;
    }
    else
    {
        desconto = 0.05F;
    }
    Console.WriteLine($"O preço de {quantidade} unidades de {nomeProduto} será R${Math.Round(precoUnitario * quantidade * (1 - desconto), 2)}");
}

// MAIOR E MENOR //
static void MaiorEMenor()
{Console.Clear();
    float[] numeros = new float[10];
    for (var i = 0; i <= 9; i++)
    {
        Console.WriteLine($"Informe um valor:");
        numeros[i] = float.Parse(Console.ReadLine());
    }
    Array.Sort(numeros);
    Console.WriteLine($"O maior valor informado foi {numeros[9]} e o menos valor foi {numeros[0]}");
}

// TABUADA //
static void Tabuada()
{Console.Clear();
    for (var i = 1; i <= 10; i++)
    {
        Console.WriteLine($"TABUADA DO {i}");
        for (var n = 1; n <= 10; n++)
        {
            Console.WriteLine($"{n}x{i}={n * i}");
        }
    }
}

// PESQUISA DE NOMES //
static void PesquisaNomes()
{Console.Clear();
    string[] nomes = new string[10];
    for (var i = 0; i <= 9; i++)
    {
        Console.WriteLine($"Informe um nome:");
        nomes[i] = Console.ReadLine();
    }

    bool desejaContinuar = true;
    while (desejaContinuar == true)
    {
        Console.WriteLine($"Informe um nome a ser procurado:");
        bool nomeAchado = false;
        string nomeProcurado = Console.ReadLine();
        for (var i = 0; i < 9; i++)
        {
            if (nomes[i].ToLower() == nomeProcurado.ToLower())
            {
                Console.WriteLine($"Nome '{nomeProcurado}' achado na posição {i + 1} na lista");
                nomeAchado = true;
            }
        }
        if (nomeAchado == false)
        {
            Console.WriteLine($"Nome '{nomeProcurado}' não achado na lista.");
        }
    continuar:
        Console.WriteLine($@"Deseja procurar outro nome?
[N] Não
[S] Sim");
        string continuar = Console.ReadLine().ToUpper();
        switch (continuar)
        {
            case "N":
                desejaContinuar = false;
                break;
            case "S":
                desejaContinuar = true;
                break;
            default:
                Console.WriteLine($"VALOR INVÁLIDO");
                goto continuar;
        }
    }
}

// SEQUÊNCIA NUMÉRICA //
static void SequenciaNumerica()
{Console.Clear();
    float[] numeros = new float[15];
    for (var i = 0; i < 15; i++)
    {
        Console.WriteLine($"Informe um valor [{i + 1}/15]");
        numeros[i] = float.Parse(Console.ReadLine());
        Console.Clear();
    }
    Console.WriteLine($"Os números em ordem reversa, são:");

    for (var i = 0; i <= 14; i++)
    {
        Console.Write($"{numeros[14 - i]} ");
    }
    Console.WriteLine();
}

static bool Sair(bool continuar)
{
    string sair = "0";
    while (sair != "S" && sair != "N")
    {
        Console.WriteLine($@"Tem certeza que quer sair?
    [S] Sim, quero sair;
    [N] Não quero sair.");
        sair = Console.ReadLine();
        switch (sair)
        {
            case "S":
                return false;
                break;
            case "N":
                return true;
            default:
                Console.WriteLine($"VALOR INVÁLIDO");
                break;
        }
    }
    return true;
}

// INICIO DO PROGRAMA //

bool continuar = true;
while (continuar == true)
{
    Console.WriteLine($@"Escolha seu programa:
[1] Idade do voto
[2] Calculadora de preço de gasolina
[3] Análise de produto e desconto
[4] Análise de maior e menor;
[5] Tabuada;
[6] Pesquisador de nomes;
[7] Reversor de sequência numérica;
[8] Sair.");
    string selecao = Console.ReadLine();
    switch (selecao)
    {
        case "1":
            IdadeDeVoto();
            Continuar();
            break;
        case "2":
            CalculadoraGasolina();
            Continuar();
            break;
        case "3":
            AnaliseProduto();
            Continuar();
            break;
        case "4":
            MaiorEMenor();
            Continuar();
            break;
        case "5":
            Tabuada();
            Continuar();
            break;
        case "6":
            PesquisaNomes();
            Continuar();
            break;
        case "7":
            SequenciaNumerica();
            Continuar();
            break;
        case "8":
            Sair(continuar);
            break;
        default:
            Console.WriteLine($"-+-+-VALOR INVÁLIDO-+-+-");
            break;
    }
}
Console.WriteLine($"OBRIGADO POR VISITAR!");
Console.ReadLine();
Environment.Exit(0);