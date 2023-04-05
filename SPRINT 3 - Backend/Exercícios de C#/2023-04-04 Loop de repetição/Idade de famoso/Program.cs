int idade = 0;
while (idade != 92){
    Console.WriteLine($"Qual a idade do Sílvio Santos?");
    idade = int.Parse(Console.ReadLine());
    if (idade != 92){
        Console.WriteLine($"ERROU!!!!");
    }
}
Console.WriteLine($@"-+-+-CORRETO-+-+-"); 