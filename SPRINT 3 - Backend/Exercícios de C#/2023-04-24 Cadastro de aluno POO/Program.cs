using Cadastro_de_aluno_POO;

// Variáveis para ordenar alunos
Alunos aluno1 = new Alunos();
int slotLivre = 0;
List<Alunos> Aluno = new List<Alunos>();

// Mensagem de erro padronizada
void ValorInvalido(string MensagemDeErro)
{
    Console.Clear();
    Console.WriteLine($"VALOR INVÁLIDO ! {MensagemDeErro}");
    Console.Write($"Aperte ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

// Tela inicial
bool loopManeiro = true;
while (loopManeiro == true)
{
    Console.Clear();
    Console.WriteLine($"CADASTRO DE ALUNOS");
    Console.WriteLine();
    Console.WriteLine($"[1] Cadastrar alunos");
    Console.WriteLine($"[2] Listar alunos");
    Console.WriteLine($"[0] Sair");
    string menuInput = Console.ReadLine()!;
    switch (menuInput)
    {
        case "1": // Cadastrar alunos
            Aluno.Add(aluno1);
            Console.Clear();
            Console.WriteLine($"Informe o nome do aluno:");
            Aluno[slotLivre].nome = Console.ReadLine()!;
            Console.WriteLine();
            Console.WriteLine($"Informe o curso do aluno:");
            Aluno[slotLivre].curso = Console.ReadLine()!;
            Console.WriteLine();
            Console.WriteLine($"Informe a idade do aluno:");
            Aluno[slotLivre].idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.WriteLine($"Informe o RG do aluno:");
            Aluno[slotLivre].rg = Console.ReadLine()!;
            Console.WriteLine();
            Console.WriteLine($"Informe se o aluno é bolsista:");
            Console.WriteLine($"[1] Sim");
            Console.WriteLine($"[2] Não");
            string bolsistaInput = Console.ReadLine()!;
            switch (bolsistaInput)
            {
                case "1":
                    Aluno[slotLivre].bolsista = true;
                    break;
                case "2":
                    Aluno[slotLivre].bolsista = false;
                    break;
                default:
                    ValorInvalido("Este valor não é uma opção válida.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"Informe a média final do aluno:");
            Aluno[slotLivre].mediaFinal = float.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.WriteLine($"Informe a mensalidade do aluno:");
            Aluno[slotLivre].mensalidade = float.Parse(Console.ReadLine()!);
            Console.Clear();
            Console.WriteLine($"Aluno cadastrado com sucesso!");
            Console.Write($"Aperte ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            slotLivre++;
            break;

        case "2": // Listar alunos
            Console.Clear();
            Console.WriteLine($"ALUNOS CADASTRADOS");
            Console.WriteLine();
            for (var i = 0; i < slotLivre; i++)
            {
                Console.WriteLine($"ALUNO {i + 1}:{Aluno[i].nome}");
            }
            Console.Write($"Insira o número do perfil de um aluno para analisar, insira 0 se quiser voltar:");
            int alunoInput = int.Parse(Console.ReadLine()!);
            if (alunoInput == 0)
            {
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Aluno {alunoInput}");
                Console.WriteLine($"Nome  = {Aluno[alunoInput - 1].nome}");
                Console.WriteLine($"Curso = {Aluno[alunoInput - 1].curso}");
                Console.WriteLine($"Idade = {Aluno[alunoInput - 1].idade}");
                Console.WriteLine($"RG    = {Aluno[alunoInput - 1].rg}");
                if (Aluno[alunoInput - 1].bolsista == true)
                {
                    System.Console.WriteLine("Aluno bolsista.");
                }
                else
                {
                    System.Console.WriteLine("Aluno não bolsista.");
                }

                Console.WriteLine($"Funções adicionais:");
                Console.WriteLine($"[1] Mostrar média final");
                Console.WriteLine($"[2] Calcular mensalidade descontada");
                string funcaoInput = Console.ReadLine()!;
                switch (funcaoInput)
                {
                    case "1":
                        Aluno[alunoInput - 1].VerMediaFinal();
                        break;
                    case "2":
                        Aluno[alunoInput - 1].VerMensalidade();
                        break;
                }
            }
            break;
        case "0": //Sair
            Console.WriteLine($"Obrigado por usar nosso sistema de cadastro");
            Console.Write($"Aperte ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            break;
        default: //Erro
            ValorInvalido("Este valor não é uma opção válida.");
            break;
    }
}