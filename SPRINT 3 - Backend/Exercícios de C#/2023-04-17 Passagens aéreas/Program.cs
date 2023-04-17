
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

// TELA DE INÍCIO //

bool loopTelaInicio = true;
while (loopTelaInicio == true)
{
    Console.Clear();
    Console.WriteLine($@"
 Bem vindo a:
 RICARDÃO TURISMO

 [1] Login
 [2] Cadastro
 [0] Sair");
    string telaInicio = Console.ReadLine();
    switch (telaInicio)
    {
        case "1":
            loopTelaInicio = false;
            break;
        case "2":
            loopTelaInicio = false;
            Cadastro(0, "");
            slotLivre++;
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

int slotLivre = 0;
string[] userNome = new string[6];
string[] userSenha = new string[6];
// string[] vaga = new string[6];
// string[] destino = new string[6];
// string[] dataDeVoo = new string[6];

// TELA DE CADASTRO //

static void Cadastro(int slotLivre, string mensagemDeErro)
{
    string[] userNome = new string[6];
    string[] userSenha = new string[6];
    string confirmacao = "";
    for (var i = 1; i <= 3;)
    {
        Console.WriteLine($@"CADASTRE-SE [{i}/3]");
        switch (i)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"Informe o nome do usuário:");
                userNome[slotLivre] = Console.ReadLine();
                if (userNome[slotLivre].Length > 32)
                {
                    Console.Clear();
                    ValorInvalido(mensagemDeErro = "Seu NOME DE USUÁRIO não pode ter mais que 32 dígitos.");
                    Console.Write($"Pressione ENTER para continuar...");
                }
                else if ((userNome[slotLivre].Length < 2))
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
                Console.WriteLine($@"Informe sua senha:
                [0] Sair");
                userSenha[slotLivre] = Console.ReadLine();
                if (userSenha[slotLivre] == "0")
                {
                    Sair();
                }
                else if (userNome[slotLivre].Length > 16)
                {
                    Console.Clear();
                    ValorInvalido(mensagemDeErro = "Sua SENHA não pode ter mais que 16 dígitos.");
                    Console.Write($"Pressione ENTER para continuar...");
                }
                else if ((userNome[slotLivre].Length < 8))
                {
                    Console.Clear();
                    ValorInvalido(mensagemDeErro = "Sua SENHA precisa ter 8 dígitos ou mais.");
                    Console.Write($"Pressione ENTER para continuar...");
                }
                else
                {
                    i++;
                }
                break;
            case 3:
                Console.Clear();
                Console.WriteLine($@"Informe sua senha novamente:");
                confirmacao = Console.ReadLine();
                if (confirmacao != (userNome[slotLivre])){
                    Console.WriteLine($"As SENHAS inseridas não são iguais");
                }
                else
                {
                    i++;
                }
                break;
        }
        Console.Clear();
        Console.WriteLine($"USUÁRIO CADASTRADO COM SUCESSO");
    }
    slotLivre++;
}
return slotLivre++;