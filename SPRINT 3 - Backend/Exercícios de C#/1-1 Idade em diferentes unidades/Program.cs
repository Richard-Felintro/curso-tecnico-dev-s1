// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Text");
Console.WriteLine($"Informe a sua idade em anos: ");
float anos = float.Parse(Console.ReadLine());

float meses = anos * 12;
float dias = meses * 30;
float horas = dias * 24;
float minutos = horas * 60;

Console.WriteLine(@$"Sua idade é: 
{anos} em anos;
ou {meses} em meses;
ou {dias} em dias;
ou {horas} em horas;
ou {minutos} em minutos;

");