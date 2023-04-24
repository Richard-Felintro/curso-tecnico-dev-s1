using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2023_04_24_Cadastro_de_aluno_POO;

Alunos aluno1 = new Alunos();
int slotLivre = 0;

List<Alunos> Aluno = new List<Alunos>();

void ValorInvalido(string MensagemDeErro)
{
    Console.Clear();
    Console.WriteLine($"VALOR INVÁLIDO ! {MensagemDeErro}");
    Console.Write($"Aperte ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

inicio:
Console.Clear();
Console.WriteLine($"CADASTRO DE ALUNOS");
Console.WriteLine();
Console.WriteLine($"[1] Cadastrar alunos");
Console.WriteLine($"[2] Listar alunos");
Console.WriteLine($"[0] Sair");
string menuInput = Console.ReadLine();
switch (menuInput)
{
    case "1":
        Console.Clear();
        Console.WriteLine($"Informe o nome do aluno:");
        Aluno[slotLivre].nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Informe o curso do aluno:");
        Aluno[slotLivre].curso = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Informe a idade do aluno:");
        Aluno[slotLivre].idade = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Informe o RG do aluno:");
        Aluno[slotLivre].rg = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Informe se o aluno é bolsista:");
        Console.WriteLine($"[1] Sim");
        Console.WriteLine($"[2] Não");
        string bolsistaInput = Console.ReadLine();
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
        Console.Clear();
        Console.WriteLine($"Informe a média final do aluno:");
        Aluno[slotLivre].mediaFinal = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Informe a mensalidade do aluno:");
        Aluno[slotLivre].mensalidade = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Aluno cadastrado com sucesso!");
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
        slotLivre++;
        break;
    case "2":
        Console.Clear();
        Console.WriteLine($"ALUNOS");
        for (var i = 0; i < slotLivre; i++)
        {
            Console.WriteLine($"ALUNO {i + 1}:{Aluno[i].nome}");
        }
        Console.Write($"Insira o número do perfil de um aluno para analisar, insira 0 se quiser voltar:");
        int alunoInput = int.Parse(Console.ReadLine());
        if (alunoInput == 0)
        {
            goto inicio;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Aluno {alunoInput}");
            Console.WriteLine($"Nome = {Aluno[alunoInput].nome}");
            Console.WriteLine($"Curso = {Aluno[alunoInput].curso}");
            Console.WriteLine($"Idade = {Aluno[alunoInput].idade}");
            Console.WriteLine($"RG    = {Aluno[alunoInput].rg}");
            if (Aluno[alunoInput].bolsista == true)
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
            string funcaoInput = Console.ReadLine();
            switch (funcaoInput)
            {
                case "1":
                    Console.WriteLine($"Média final = {Aluno[alunoInput].mediaFinal}");
                    break;
                case "2":
                    if (Aluno[alunoInput].bolsista == false)
                    {
                        Console.WriteLine($"Desconto indisponível, R${Aluno[alunoInput].mensalidade}");
                    }
                    else
                    {
                        if (Aluno[alunoInput].mediaFinal > 6 && Aluno[alunoInput].mediaFinal < 8)
                        {
                            Console.WriteLine($"Sua média descontada é {Aluno[alunoInput].mensalidade * 0.7}");
                        }
                        else if (Aluno[alunoInput].mediaFinal >= 8)
                        {
                            Console.WriteLine($"Sua média descontada é {Aluno[alunoInput].mensalidade * 0.5}");
                        }
                        else
                        {
                            Console.WriteLine($"Desconto indisponível, R${Aluno[alunoInput].mensalidade}");
                        }
                    }
                    break;
            }
        }
        break;
    case "0":
        break;
    default:
        ValorInvalido("Este valor não é uma opção válida.");
        break;
}