using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class MaquinaCafe
    {
        public float acucarDisponivel = 0;
        public float acucarMaximo { get; set; }
        public void Tabajaras(MaquinaCafe cafeteira)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Super Cafeteira Tabajaras Plus ++");
            Console.ResetColor();
            Console.WriteLine($"Açucar : {cafeteira.acucarDisponivel}g/{cafeteira.acucarMaximo}g");
        }
        //* FAZER CAFÉ COM AÇUCAR ESPECIFICADO
        public void FazerCafe(float acucarInput)
        {
            Tabajaras(this);
            if (acucarInput > this.acucarDisponivel)
            {
                Console.WriteLine($"Quantia de açucar indisponível");
                Console.Write($"Aperte ENTER para continuar...");
                Console.ReadLine();
                return;
            }
            Tabajaras(this);
            Console.Write($"Preparando seu cafézinho");
            for (var i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }
            acucarDisponivel -= acucarInput;
            Console.Clear();
            Tabajaras(this);
            Cafezinho();
        }
        //* FAZER CAFÉ SEM ESPECIFICAR O AÇUCAR
        public void FazerCafe()
        {
            float acucarCusto;
            Tabajaras(this);
            if (acucarDisponivel >= 10)
            {
                Console.WriteLine($"Quantia de açucar não informada, adicionando 10g");
                acucarCusto = 10;
            }
            else
            {
                Console.WriteLine($"Quantia de açucar não informada, adicionando {acucarDisponivel}g");
                acucarCusto = acucarDisponivel;
            }
            Console.Write($"Preparando seu cafézinho");
            acucarDisponivel -= acucarCusto;
            for (var i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }
            Console.Clear();
            Tabajaras(this);
            Cafezinho();
        }
        //* MÉTODO PARA ABASTECER A CAFETEIRA COM AÇUCAR
        public float Abastecer()
        {
            Tabajaras(this);
            float retorno = 0;
            Console.Write($"Informe a quantia de gramas de açucar a ser adicionada...");
            float acucarAdicionar = float.Parse(Console.ReadLine()!);
            acucarDisponivel += acucarAdicionar;
            if (acucarDisponivel > acucarMaximo)
            {
                retorno = acucarDisponivel - acucarMaximo;
                acucarDisponivel = acucarMaximo;
            }
            return retorno;
        }
        public void Cafezinho()
        {
            Console.Clear();
            Tabajaras(this);
            Console.WriteLine($"Cafézinho está pronto");
            Console.WriteLine($@"
                                    (
                          )     (
                   ___...(-------)-....___
               .-''       )    (          ''-.
         .-'``'|-._             )         _.-|
        /  .--.|   `''---...........---''`   |
       /  /    |                             |
       |  |    |                             |
        \  \   |                             |
         `\ `\ |                             |
           `\ `|                             |
           _/ /\                             /
          (__/  \                           /
       _..---''` \                         /`''---.._
    .-'           \                       /          '-.
   :               `-.__             __.-'              :
   :                  ) ''---...---'' (                 :
    '._               `'--...___...--'`              _.'
      \''--..__                              __..--''/
       '._     '''----.....______.....----'''     _.'
          `''--..,,_____            _____,,..--''`
                        `'''----'''`");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}