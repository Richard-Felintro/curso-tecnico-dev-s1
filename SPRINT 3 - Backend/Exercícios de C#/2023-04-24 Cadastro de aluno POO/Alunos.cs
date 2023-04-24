using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_24_Cadastro_de_aluno_POO
{
    public class Alunos
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public Boolean bolsista;
        public float mediaFinal;
        public float mensalidade;

        // Métodos
        // Atacar, defender, restaurar armadura

        public void VerMediaFinal()
        {
            Console.WriteLine($"O personagem atacou !");

        }
        public void VerMensalidade()
        {
            Console.WriteLine($"O personagem Defendeu !");

        }
    }
}