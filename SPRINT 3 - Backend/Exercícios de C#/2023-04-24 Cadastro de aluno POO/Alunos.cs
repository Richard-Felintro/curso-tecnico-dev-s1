namespace Cadastro_de_aluno_POO
{
    public class Alunos
    {
        //* Variáveis para cadastro do aluno
        public string? nome;
        public string? curso;
        public int idade;
        public string? rg;
        public Boolean bolsista;
        public float mediaFinal;
        public float mensalidade;
        
        //* Funções de análise do perfil do aluno
        public void VerMediaFinal() //*Mostrar média do aluno
        {
            Console.WriteLine($"Média final = {Math.Round(mediaFinal, 2)}");
        }
        public void VerMensalidade() //*Calcular a mensalidade incluindo descontos de bolsista
        {
            if (bolsista == false)
            {
                Console.WriteLine($"Desconto indisponível, R${Math.Round(mensalidade, 2)}");
            }
            else
            {
                if (mediaFinal > 6 && mediaFinal < 8)
                {
                    Console.WriteLine($"Sua média descontada é R${Math.Round(mensalidade * 0.7, 2)}");
                }
                else if (mediaFinal >= 8)
                {
                    Console.WriteLine($"Sua média descontada é R${Math.Round(mensalidade * 0.5, 2)}");
                }
                else
                {
                    Console.WriteLine($"Desconto indisponível, R${Math.Round(mensalidade, 2)}");
                }
            }

        }
    }
}