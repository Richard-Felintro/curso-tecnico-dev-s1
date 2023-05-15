using static System.Console;
using Contrato_de_negocio;

string cpfInput = "n";
bool cpfVerificado = false;
string cnpjInput = "n";
bool cnpjVerificado = false;

Agenda agenda = new Agenda();

void MudarMenu(string x)
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
Console.WriteLine($"[2] Listar Contatos\n");
Console.WriteLine($"[0] Sair");
string menuInput = Console.ReadLine();
switch (menuInput)
{
    case "1":
        MudarMenu("Selecione o tipo do contato:");
        Console.WriteLine($"[1] Contato Pessoal");
        Console.WriteLine($"[2] Contato Comercial");
        string tipoInput = Console.ReadLine();
        switch (tipoInput)
        {
            case "1":
                ContatoPessoal contaP = new ContatoPessoal();
                MudarMenu("Informe o nome do contato:");
                contaP.Nome = Console.ReadLine();
                MudarMenu("Informe o telefone do contato:");
                contaP.Nome = Console.ReadLine();
                MudarMenu("Informe o email do contato:");
                contaP.Nome = Console.ReadLine();
                cpfVerificado = false;
                while (cpfVerificado != true)
                {
                    MudarMenu("Informe o CPF do contato:");
                    cpfInput = Console.ReadLine();
                    cpfVerificado = contaP.ValidarCpf(cpfInput);
                }
                contaP.Cpf = cpfInput;
                agenda.Adicionar(contaP);
                MudarMenu("Contato registrado com sucesso");
                Console.Write($"Aperte ENTER para continuar...");
                Console.ReadLine();
                break;
            case "2":
                ContatoComercial contaC = new ContatoComercial();
                MudarMenu("Informe o nome do contato:");
                contaC.Nome = Console.ReadLine();
                MudarMenu("Informe o telefone do contato:");
                contaC.Nome = Console.ReadLine();
                MudarMenu("Informe o email do contato:");
                contaC.Nome = Console.ReadLine();
                cnpjVerificado = false;
                while (cnpjVerificado != true)
                {
                    MudarMenu("Informe o CNPJ do contato:");
                    cnpjInput = Console.ReadLine();
                    cnpjVerificado = contaC.ValidarCnpj(cnpjInput);
                }
                contaC.Cnpj = cnpjInput;
                agenda.Adicionar(contaC);
                MudarMenu("Contato registrado com sucesso");
                Console.Write($"Aperte ENTER para continuar...");
                Console.ReadLine();
                break;
            default:
                MudarMenu("Valor inválido");
                Console.Write($"Aperte ENTER para continuar...");
                goto loopMenu;
        }
        break;
    case "2":
        agenda.Listar();
        break;
    case "0":
        MudarMenu("Fechando programa");
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
        Environment.Exit(1);
        break;
    default:
        MudarMenu("Valor inválido");
        Console.Write($"Aperte ENTER para continuar...");
        goto loopMenu;
}
goto loopMenu;