
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

// MÉTODO DE SAIR DA PÁGINA //

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
    Console.WriteLine($"VALOR INVÁLIDO ! {mensagemDeErro}");
    Console.Write($"Pressione ENTER para continuar...");
    Console.ReadLine();
    return;
}

// MÉTODO DE SAIR DA CONTA //

static void SairDaConta()
{
    static void Sair()
    {
        Console.Clear();
        string desejaSair = "666";
        while (desejaSair != "1" && desejaSair != "2")
        {
            Console.WriteLine($@"
    Tem certeza que quer sair de sua conta?
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
}

// MÉTODO DE LOGIN //

static void Login(bool loopTelaInicio)
{
    bool loopLogin = true;
    while (loopLogin == true)
    {
        Console.Clear();
        Console.WriteLine($@"Insira a senha:
    [0] Sair");
        string loginTentativa = Console.ReadLine();
        if (loginTentativa == "0")
        {
            Sair();
        }
        else if (loginTentativa == "123456")
        {
            Console.Clear();
            Console.WriteLine($"LOGIN EFETUADO COM SUCESSO");
            Console.Write($"Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            loopTelaInicio = false;
            loopLogin = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"SENHA INCORRETA");
            Console.Write($"Pressione ENTER para continuar...");
            Console.ReadLine();
            loopTelaInicio = false;
        }
    }
}

// TELA DE INÍCIO //
bool loopTelaInicio = true;
while (loopTelaInicio == true)
{
    Console.Clear();
    Console.WriteLine($@"
 Bem vindo a:
 RICARDÃO TURISMO

 [1] Login
 [0] Sair");
    string telaInicio = Console.ReadLine();
    switch (telaInicio)
    {
        case "1":
            Login(true);
            loopTelaInicio = false;
            break;
        case "0":
            Sair();
            break;
        default:
            ValorInvalido(mensagemDeErro = "O valor inserido não é uma opção válida");
            break;
    }
}

// VARIÁVEIS DE CADASTRO //
int anoTentativa = 0;
int mesTentativa = 0;
int diaTentativa = 0;
string origemTentativa = "";
string nomeTentativa = "";
string destinoTentativa = "";
bool cadastroCorreto = false;

int[] anoCadastrado = new int[5];
int[] mesCadastrado = new int[5];
int[] diaCadastrado = new int[5];
string[] origemCadastrado = new string[5];
string[] nomeCadastrado = new string[5];
string[] destinoCadastrado = new string[5];

int slotLivre = 0;

bool loopLogado = true;
while (loopLogado == true)
{
    Console.WriteLine($@"RICARDÃO TURISMO

[1] Listar passagens
[2] Cadastrar passagem
[9] Sair da sua conta
[0] Sair");

    string inputCadastro = Console.ReadLine();
    switch (inputCadastro)
    {
        case "1":
            Console.Clear();
            if (slotLivre == 0)
            {
                Console.WriteLine($"Nenhum USUÁRIO foi cadastrado até o momento.");
                Console.Write($"Pressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                for (var i = 0; i <= slotLivre; i++)
                {
                    Console.WriteLine($"PASSAGEM {i}");
                    Console.WriteLine($"Nome do passageiro: {nomeCadastrado[slotLivre]}");
                    Console.WriteLine($"Origem do voo: {origemCadastrado[slotLivre]}");
                    Console.WriteLine($"Destino do voo: {destinoCadastrado[slotLivre]}");
                    Console.WriteLine($"Data do voo: {diaCadastrado[slotLivre]}/{mesCadastrado[slotLivre]}/{anoCadastrado[slotLivre]}");
                }
                Console.Write($"Pressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            break;
        case "2":
            Cadastrar(false, "", "", "", 0, 0, 0, "");
            anoCadastrado[slotLivre] = anoTentativa;
            mesCadastrado[slotLivre] = mesTentativa;
            diaCadastrado[slotLivre] = diaTentativa;
            origemCadastrado[slotLivre] = origemTentativa;
            nomeCadastrado[slotLivre] = nomeTentativa;
            destinoCadastrado[slotLivre] = destinoTentativa;
            slotLivre++;
            break;
        case "9":
            SairDaConta();
            break;
        case "0":
            Sair();
            break;
        default:
            ValorInvalido(mensagemDeErro = "O valor inserido não é uma opção válida");
            break;
    }
}
static void Cadastrar(bool cadastroCorreto, string destinoTentativa, string nomeTentativa, string origemTentativa, int diaTentativa, int mesTentativa, int anoTentativa, string mensagemDeErro)
{
    string dataTentativa = "ph";
    for (var i = 1; i <= 4;)
    {
        Console.Clear();
        Console.WriteLine($@"CADASTRE-SE [{i}/4]");
        switch (i)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($@"Informe o nome do passageiro:");
                Console.WriteLine($"[9] Retornar");
                Console.WriteLine($"[0] Sair");
                nomeTentativa = Console.ReadLine();
                if (nomeTentativa == "0")
                {
                    Sair();
                }
                if (nomeTentativa == "9")
                {
                    i = 1;
                    return;
                }
                else if ((nomeTentativa.Length < 2))
                {
                    Console.Clear();
                    ValorInvalido(mensagemDeErro = "Seu NOME DE USUÁRIO não pode ser um único dígito.");
                    Console.Write($"Pressione ENTER para continuar...");
                }
                else
                {
                    i++;
                }
                break;
            case 2:
                Console.Clear();
                Console.WriteLine($@"Informe sua origem:");
                Console.WriteLine($"[9] Retornar");
                Console.WriteLine($"[0] Sair");
                destinoTentativa = Console.ReadLine();
                if (destinoTentativa == "0")
                {
                    Sair();
                }
                else if (destinoTentativa == "9")
                {
                    i = 1;
                    return;
                }
                else
                {
                    i++;
                }
                break;
            case 3:
                Console.Clear();
                Console.WriteLine($@"Informe seu destino:");
                Console.WriteLine($"[9] Retornar");
                Console.WriteLine($"[0] Sair");
                nomeTentativa = Console.ReadLine();
                if (origemTentativa == "0")
                {
                    Sair();
                }
                else if (origemTentativa == "9")
                {
                    i = 1;
                    return;
                }
                else
                {
                    i++;
                }
                break;
            case 4:
                for (var n = 0; n < 4;)
                {
                    switch (n)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine($@"Sessão de informação de data");
                            Console.WriteLine($"[9] Retornar");
                            Console.WriteLine($"[0] Sair");
                            Console.Write($"Pressione ENTER para continuar...");
                            dataTentativa = Console.ReadLine();
                            if (dataTentativa == "0")
                            {
                                Sair();
                            }
                            else if (dataTentativa == "9")
                            {
                                i = 1;
                                return;
                            }
                            else
                            { n++; }
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"Informe o seu ano de partida:");
                            anoTentativa = int.Parse(Console.ReadLine());
                            if (anoTentativa < DateTime.Now.Year)
                            {
                                ValorInvalido("Esta DATA de partida está no passado");
                            }
                            else
                            {
                                n++;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine($"Informe o seu mes de partida (em números):");
                            mesTentativa = int.Parse(Console.ReadLine());
                            if (mesTentativa > 12 || mesTentativa < 1)
                            {
                                ValorInvalido("O valor de MÊS informado não é de 1 a 12");
                            }
                            else
                            {
                                n++;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine($"Informe o seu dia de partida (em números):");
                            diaTentativa = int.Parse(Console.ReadLine());
                            if (mesTentativa == 2 && diaTentativa > 29)
                            {
                                ValorInvalido("DIA informado não coincide com Mês mencionado");
                            }
                            else if (mesTentativa == 4 || mesTentativa == 6 || mesTentativa == 9 || mesTentativa == 11 && diaTentativa > 30)
                            {
                                ValorInvalido("DIA informado não coincide com Mês mencionado");
                            }
                            else if (diaTentativa > 31)
                            {
                                ValorInvalido("DIA informado não coincide com Mês mencionado");
                            }
                            else
                            {
                                cadastroCorreto = true;
                                n++;
                                i++;
                            }
                            break;
                    }
                }
                break;
        }
    }
    Console.Clear();
    Console.WriteLine($"PASSAGEM CADASTRADA COM SUCESSO");
    Console.Write($"Pressione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
    return;
}