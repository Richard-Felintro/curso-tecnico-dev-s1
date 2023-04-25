using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_POO
{
    public class Calculadora
    {
        // PROPRIEDADE //
        public string operacao = "null";
        double n1 = 0;
        double n2 = 0;

        // MÉTODOS //
        public void Fim()
        {
            Console.Write($"Aperte ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
        public void Calculo()
        {
            Console.Clear();
            Console.WriteLine($"Informe o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"Informe o segundo número: {n1} {operacao} ");
            n2 = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        public double Adicao(double oq)
        {
            operacao = "+";
            Calculo();
            Console.WriteLine($"O resultado da operação é {n1} + {n2} = {n1 + n2}");
            Fim();
            return (n1 + n2);
        }
        public double Subtracao(double oq)
        {
            operacao = "-";
            Calculo();
            Console.WriteLine($"O resultado da operação é {n1} - {n2} = {n1 - n2}");
            Fim();
            return (n1 - n2);
        }
        public double Multiplicacao(double oq)
        {
            operacao = "*";
            Calculo();
            Console.WriteLine($"O resultado da operação é {n1} * {n2} = {n1 * n2}");
            Fim();
            return (n1 * n2);
        }
        public double Divisao(double oq)
        {
            operacao = "/";
            Calculo();
            Console.WriteLine($"O resultado da operação é {n1} / {n2} = {n1 / n2}");
            Fim();
            return (n1 / n2);
        }
        public double Potenciacao(double oq)
        {
            operacao = "^";
            Calculo();
            Console.WriteLine($"O resultado da operação é {n1} ^ {n2} = {Math.Pow(n1, n2)}");
            Fim();
            return (Math.Pow(n1, n2));
        }
        public double Radiciacao(double oq)
        {
            operacao = "\u221A";
            Calculo();
            Console.WriteLine($"O resultado da operação é {n1} \u221A {n2} = {Math.Pow(n1, 1.0 / n2)}");
            Fim();
            return (Math.Pow(n1, 1.0 / n2));
        }
        public double Porcentagem(double oq)
        {
            operacao = "%";
            Calculo();
            Console.WriteLine($"O resultado da operação é {n1} % {n2} = {n1 * (n2 / 100)}");
            Fim();
            return (n1 * (n2 / 100));
        }
    }
}