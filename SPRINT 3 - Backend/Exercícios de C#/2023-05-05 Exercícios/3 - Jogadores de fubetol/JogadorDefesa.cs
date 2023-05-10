using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeCraques
{
    public class JogadorDefesa : JogadorFutebol
    {
        public JogadorDefesa(string nome, DateTime data, string nacionalidade, float altura, float peso)
        {
            Nome = nome;
            DataNascimento = data;
            Nacionalidade = nacionalidade;
            Altura = altura;
            Peso = peso;
            Idade = DateTime.Now.Year - DataNascimento.Year;
            Aposentadoria = 40 - Idade;
        }
    }
}