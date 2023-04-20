Console.Clear();
// MÉTODO PARA SAIR DO PROGRAMA //
static void Sair()
{
    Console.Clear();
    string desejaSair = "666";
    while (desejaSair != "1" && desejaSair != "2")
    {
        Console.WriteLine($@"
    Tem certeza que quer sair?
    [1] Sim, quero sair.
    [2] Não, não quero sair ainda.");
        desejaSair = Console.ReadLine();
        switch (desejaSair)
        {
            case "1":
                Console.Clear();
                Console.WriteLine($"Obrigado por usar RICARDÃO TURISMO");
                Console.Write($"Pressione ENTER para sair...");
                Console.ReadLine();
                Environment.Exit(1);
                break;
            case "2":
                return;
                break;
            default:
                ValorInvalido("O valor inserido não é uma opção válida");
                break;
        }
    }
}

// MÉTODO CASO O USUÁRIO DIGITE UM VALOR INVÁLIDO //

string mensagemDeErro = "Se está vendo isso eu fiz algo de errado :)";
static void ValorInvalido(string mensagemDeErro)
{
    Console.Clear();
    Console.WriteLine($"VALOR INVÁLIDO ! {mensagemDeErro}");
    Console.Write($"Pressione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
    return;
}

string userName = "";
// VARIÁVEIS DE PRODUTO //
int slotLivre = 0;
string[] produtoNome = new string[32767];
float[] produtoPreco = new float[32767];
bool[] produtoDesc = new bool[32767];
float[] desconto = new float[32767];

// LOGIN //
voltarLogin:
bool loginLoop = true;
while (loginLoop == true)
{
    Console.WriteLine($"MERCADÃO RICARDÃO inc");
    Console.WriteLine();
    Console.WriteLine($"[1] Cadastar");
    Console.WriteLine($"[2] Login");
    Console.WriteLine($"[0] Sair");
    string loginInput = Console.ReadLine();
    switch (loginInput)
    {
        case "1":
            ValorInvalido("Funcão de cadastro temporariamente indisponível devido a falhas técnicas...");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine($"Informe o nome do usuário:");
            Console.WriteLine($"[0] Sair");
            userName = Console.ReadLine();
            if (userName == "0")
            {
                Sair();
            }
            Console.Clear();
            Console.WriteLine($"Informe a senha:");
            string senha = Console.ReadLine();
            if (senha != "123456")
            {
                Console.Clear();
                Console.WriteLine($"SENHA INCORRETA");
                Console.Write($"Pressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Usuário logado com sucesso!");
                Console.Write($"Pressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                loginLoop = false;
            }
            break;
        case "0":
            Sair();
            break;
    }
}

// INÍCIO //

string menuInput = "";
bool menuLoop = true;
while (menuLoop == true)
{
voltarMenu:
    menuInput = "";
    Console.WriteLine($"Gerenciador de Produtos");
    Console.WriteLine($"Usuário : {userName}");
    Console.WriteLine();
    Console.WriteLine($" [1] Cadastrar produtos");
    Console.WriteLine($" [2] Listar produtos");
    Console.WriteLine($" [9] Sair de sua conta");
    Console.WriteLine($" [0] Sair");
    menuInput = Console.ReadLine();
    switch (menuInput)
    {
        case "1":
        cadastro:
            Console.Clear();
            Console.WriteLine($"Informe o nome do produto {slotLivre + 1}:");
            Console.WriteLine($"[9] Voltar");
            Console.WriteLine($"[0] Sair");
            produtoNome[slotLivre] = Console.ReadLine();
            switch (produtoNome[slotLivre])
            {
                case "9":
                    Console.Clear();
                    goto voltarLogin;
                    break;
                case "0":
                    Sair();
                    break;
                default:
                    Console.Clear();
                    break;
            }
            Console.WriteLine($"Informe o preço do produto {slotLivre + 1}:");
            Console.WriteLine($"[9] Voltar");
            Console.WriteLine($"[0] Sair");
            produtoPreco[slotLivre] = float.Parse(Console.ReadLine());
            switch (produtoPreco[slotLivre])
            {
                case 9:
                    Console.Clear();
                    goto voltarMenu;
                    break;
                case 0:
                    Sair();
                    break;
                default:
                    produtoPreco[slotLivre] = (float)Math.Round((decimal)produtoPreco[slotLivre], 2);
                    Console.Clear();
                    break;
            }
            Console.WriteLine($"Informe se o produto {slotLivre + 1} está em desconto:");
            Console.WriteLine($"[1] Sim, está em desconto");
            Console.WriteLine($"[2] Não, não está em desconto");
            Console.WriteLine($"[9] Voltar");
            Console.WriteLine($"[0] Sair");
            string descontoInput = (Console.ReadLine());
            switch (descontoInput)
            {
                case "1":
                    produtoDesc[slotLivre] = true;
                    Console.WriteLine($"Informe o percentual de desconto:");
                    desconto[slotLivre] = float.Parse(Console.ReadLine());
                    break;
                case "2":
                    produtoDesc[slotLivre] = false;
                    break;
                case "9":
                    Console.Clear();
                    goto voltarMenu;
                    break;
                case "0":
                    Sair();
                    break;
                default:
                    ValorInvalido(mensagemDeErro = "Valor informado inválido");
                    break;
            }
            Console.Clear();
            slotLivre++;
            Console.WriteLine($"Produto cadastrado com sucesso!");
            Console.Write($"Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            break;
        case "2":
            Console.Clear();
            if (slotLivre == 0)
            {
                ValorInvalido("Nenhum produto foi cadastrado até o momento.");
            }
            else
            {
                for (var i = 0; i < slotLivre; i++)
                {
                    Console.WriteLine($"PRODUTO {i + 1}");
                    Console.WriteLine($"Nome  : {produtoNome[i]}");
                    Console.WriteLine($"Preço : R${produtoPreco[i]} (R${(float)Math.Round(produtoPreco[i]*(1-desconto[i]/100), 2)})");
                    if (produtoDesc[i] == true)
                    {
                        Console.WriteLine($"PROMOÇÃO: {desconto[i]}%");
                    }
                    else
                    {
                        Console.WriteLine($"SEM PROMOÇÃO");
                    }
                    Console.WriteLine();
                }
                Console.Write($"Pressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            break;
        case "9":
            Console.Clear();
            goto voltarMenu;
            break;
        case "0":
            Sair();
            break;
    }
}