using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular_POO
{
    public class Celular
    {
        public string? modelo;
        public int tamanho;
        public string? cor;
        public bool ligado = false;
        //* Métodos
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            Console.Clear();
            Console.WriteLine($"Desligando. Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            ligado = false;
        }
        public void FazerLigacao()
        {
            Console.Clear();
            Console.WriteLine($"TELEFONE");
            Console.WriteLine();
            Console.Write($"Digite o número...");
            double numeroLigando = int.Parse(Console.ReadLine()!);
            if (numeroLigando < 100000000 || numeroLigando >= 99999999999)
            {
                Console.WriteLine($"Número inválido...");
            }
            else
            {
                Console.WriteLine($"Ligando...");
                Console.Write($"Aperte ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"O destinatário achou que era golpe e desligou :(");
            }
        }
        public void EnviarMensagem()
        {
            Console.Clear();
            Console.WriteLine($"Enviando mensagem...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}