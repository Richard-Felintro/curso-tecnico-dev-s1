using Calculadora_POO;

Console.Clear();
Calculadora calc = new Calculadora();
bool loop = true;
double oq = 0;

while (loop == true)
{
    Console.WriteLine($"Calculadora em POO");
    Console.WriteLine();
    Console.WriteLine($"Escolha uma operação:");
    Console.WriteLine($"[1] + Adicão");
    Console.WriteLine($"[2] - Subtração");
    Console.WriteLine($"[3] * Multiplicação");
    Console.WriteLine($"[4] / Divisão");
    Console.WriteLine($"[5] ^ Potenciação");
    Console.WriteLine($"[6] \u221A Radiciação");
    Console.WriteLine($"[7] % Porcentagem");
    Console.WriteLine();
    Console.WriteLine($"[0] Sair");

    string operacaoInput = Console.ReadLine();
    switch (operacaoInput)
    {
        case "1":
            calc.Adicao(0);
            break;
        case "2":
            calc.Subtracao(0);
            break;
        case "3":
            calc.Multiplicacao(0);
            break;
        case "4":
            calc.Divisao(0);
            break;
        case "5":
            calc.Potenciacao(0);
            break;
        case "6":
            calc.Radiciacao(0);
            break;
        case "7":
            calc.Porcentagem(0);
            break;
        case "0":
            Console.WriteLine($"Obrigado por usar minha calculadora :)");
            calc.Fim();
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine($"Valor inválido");
            calc.Fim();
            break;
    }
}