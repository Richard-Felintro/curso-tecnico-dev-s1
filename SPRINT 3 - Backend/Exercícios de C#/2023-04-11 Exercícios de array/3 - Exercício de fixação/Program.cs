string[] nome = new string[5];
int[] idade = new int[5];

for (var i = 0; i < 5; i++) {
    Console.WriteLine($"Informe seu nome:");
    nome[i] = Console.ReadLine();
    Console.WriteLine($"Informe sua idade:");
    idade[i] = int.Parse(Console.ReadLine());
}

for (var i = 0; i < 5; i++) {
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"PESSOA {i + 1} ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Meu nome é {nome[i]}.");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"Tenho {idade[i]} anos de idade.");
}