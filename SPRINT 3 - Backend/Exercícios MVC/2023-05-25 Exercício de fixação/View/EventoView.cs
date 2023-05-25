using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_de_fixacao.Controller;
using Exercicio_de_fixacao.Model;

namespace Exercicio_de_fixacao.View
{
    public class EventoView
    {
        bool Loop = true;
        public void GerarMenu(string x)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gerenciador de eventos");
            Console.ResetColor();
            Console.WriteLine(x);
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            GerarMenu("Informe o nome do evento:");
            novoEvento.Nome = Console.ReadLine();
            GerarMenu("Informe a data do evento:");
            novoEvento.Data = DateTime.Parse(Console.ReadLine()!);
            GerarMenu("Informe o nome do evento:");
            novoEvento.Descricao = Console.ReadLine();

            return novoEvento;
        }
        public void Listar(List<Evento> eventos)
        {
            foreach (var e in eventos)
            {
                Console.WriteLine($"Evento...{e.Nome}");
                Console.WriteLine($"Data.....{e.Data}");
                Console.WriteLine($"{e.Descricao}");
            }
        }
    }
}