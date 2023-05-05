using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevadorNS
{
    public class Elevador
    {
        public int andarAtual {get; set;}= 0;
        public int andarMaximo {get; set;}
        public int pessoasAtual {get; set;} = 0;
        public int pessoasMaximo {get; set;}

        static void Menu(string menuMsg, string menuMsg2, bool menuEnter)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
  ______ _                     _            
 |  ____| |                   | |           
 | |__  | | _____   ____ _  __| | ___  _ __ 
 |  __| | |/ _ \ \ / / _` |/ _` |/ _ \| '__|
 | |____| |  __/\ V / (_| | (_| | (_) | |   
 |______|_|\___| \_/ \__,_|\__,_|\___/|_|   ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{menuMsg}");
            Console.ResetColor();
            Console.Write($"{menuMsg2}");
            if (menuEnter == true)
            {
                Console.ReadLine();
                Console.Clear();
            }
        }
        public void Inicializa(int andaresInput, int pessoasInput)
        {
            andarMaximo = andaresInput;
            pessoasMaximo = pessoasInput;
        }
        public void Entrar()
        {
            if (pessoasAtual < pessoasMaximo)
            {
                Menu("Um funcionário entrou no elevador\n", "Aperte ENTER para continuar...", true);
                pessoasAtual++;
            }
            else
            {
                Menu("Um funcionário foi barrado do elevador, pois já tinha atingido capacidade máximo\n", "Aperte ENTER para continuar...", true);
            }
        }
        public void Sair()
        {
            if (pessoasAtual > 0)
            {
                Menu("Um funcionário saiu do elevador\n", "Aperte ENTER para continuar...", true);
                pessoasAtual--;
            }
            else
            {
                Menu("Não resta nenhum funcionário para sair do elevador\n", "Aperte ENTER para continuar...", true);
            }
        }
        public void Subir()
        {
            if (andarAtual < andarMaximo)
            {
                Menu("O elevador subiu um andar\n", "Aperte ENTER para continuar...", true);
                andarAtual++;
            }
            else
            {
                Menu("O elevador tentou subir um andar, mas já estava no ultimo\n", "Aperte ENTER para continuar...", true);
            }
        }
        public void Descer()
        {
            if (andarAtual > 0)
            {
                Menu("O elevador desceu um andar\n", "Aperte ENTER para continuar...", true);
                andarAtual--;
            }
            else
            {
                Menu("O elevador já está no térreo\n", "Aperte ENTER para continuar...", true);
            }
        }
    }
}