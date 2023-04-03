Console.WriteLine($"Informe o número de um dia da semana:");
int dia = int.Parse(Console.ReadLine());
switch (dia)
{
    case 1:
    Console.WriteLine($"Hoje é domingo!");
    break;
    case 2:
    Console.WriteLine($"Hoje é segunda-feira!");
    break;
    case 3:
    Console.WriteLine($"Hoje é terça-feira!");
    break;
    case 4:
    Console.WriteLine($"Hoje é quarta-feira!");
    break;
    case 5:
    Console.WriteLine($"Hoje é quinta-feira!");
    break;
    case 6:
    Console.WriteLine($"Hoje é sexta-feira!");
    break;
    case 7:
    Console.WriteLine($"SABADÃOOOOO!");
    break;
    default:
    Console.WriteLine($"A semana só tem dias de 1 a 7");
    break;
}   
