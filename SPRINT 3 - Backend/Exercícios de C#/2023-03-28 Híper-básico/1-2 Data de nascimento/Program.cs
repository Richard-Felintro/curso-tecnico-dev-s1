// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Qual seu ano de nascimento: ");
int nascimento = int.Parse(Console.ReadLine());

float idade = DateTime.Now.Year - nascimento;

float semanas = idade * (365/7);

Console.WriteLine($"Voce tem {idade} anos de idade, ou {semanas} em semanas.");