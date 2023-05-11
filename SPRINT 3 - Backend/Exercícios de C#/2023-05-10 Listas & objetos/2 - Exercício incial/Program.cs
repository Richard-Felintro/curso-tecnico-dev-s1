using ExercicioCarro;
List<Carro> carros = new List<Carro>();

Console.Clear();
for (var i = 0; i < 2; i++)
{
    Console.Write($"Informe a marca do carro... ");
    string marcaInput = Console.ReadLine();
    Console.Write($"Informe a cor do carro... ");
    string corInput = Console.ReadLine();
    carros.Add(new Carro(marcaInput, corInput));
}
int x = 1;
foreach (var item in carros)
{
    Console.WriteLine($"CARRO {x}");
    Console.WriteLine($"Marca: {item.Marca}");
    Console.WriteLine($"Cor: {item.Cor}");
    Console.WriteLine();
    x++;
}