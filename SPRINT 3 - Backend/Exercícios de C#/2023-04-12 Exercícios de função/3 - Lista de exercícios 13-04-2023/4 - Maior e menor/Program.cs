float[] numeros = new float [10];
for (var i = 0; i <= 9; i++)
{
    Console.WriteLine($"Informe um valor:");
    numeros[i] = float.Parse(Console.ReadLine());
}
Array.Sort(numeros);
Console.WriteLine($"O maior valor informado foi {numeros[9]} e o menos valor foi {numeros[0]}");

// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.