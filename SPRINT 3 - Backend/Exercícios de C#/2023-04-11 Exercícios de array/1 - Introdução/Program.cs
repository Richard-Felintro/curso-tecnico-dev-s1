string[] carros = new string[5];
for (int carroAtual = 0; carroAtual <= 4; carroAtual++) {
    Console.WriteLine($"Digite o nome do carro: ");
    carros[carroAtual] = Console.ReadLine();
}
Console.WriteLine($"Lista de carros:");
foreach (string carro in carros) {
    int index = Array.FindIndex(carros, x => x.Contains(carro));
    Console.WriteLine($"Carro {index+1} : {carro}");
}