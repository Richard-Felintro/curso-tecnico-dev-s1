using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeCraques
{
    public abstract class JogadorFutebol
    {
        //* PROPRIEDADES CADASTRADAS
        public string Nome;
        public DateTime DataNascimento;
        public string Nacionalidade;
        public float Altura;
        public float Peso;
        //* PROPRIEDADES CALCULADAS
        public int Idade;
        public int Aposentadoria;
        //* MÉTODOS
        public void MudarMenu(int frase)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"!!! GERADOR DE CRAQUES 3000 !!!");
            Console.ResetColor();
            Console.WriteLine($"{frase}");
            Console.WriteLine();
        }
        public void CalcularIdade()
        {

        }
    }
}