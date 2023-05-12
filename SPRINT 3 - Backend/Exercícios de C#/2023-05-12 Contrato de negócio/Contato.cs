using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrato_de_negocio
{
    public abstract class Contato
    {
        public string Nome;
        public string Telefone;
        public string Email;
        
        static void MudarMenu(string x)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"CONTATOS");
            Console.ResetColor();
            Console.WriteLine($"{x}\n");
        }
    }
}