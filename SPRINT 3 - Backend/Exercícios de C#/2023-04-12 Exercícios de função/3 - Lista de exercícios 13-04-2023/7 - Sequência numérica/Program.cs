float[] numeros = new float [15];
for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"Informe um valor [{i+1}/15]");
    numeros[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine($"Os números em ordem reversa, são:");

for (var i = 0; i <= 14; i++)
{
    Console.Write($"{numeros[14-i]} ");
}
Console.WriteLine();

// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.