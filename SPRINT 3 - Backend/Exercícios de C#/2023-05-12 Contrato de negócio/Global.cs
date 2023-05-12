using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrato_de_negocio
{
    public static class Global
    {
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