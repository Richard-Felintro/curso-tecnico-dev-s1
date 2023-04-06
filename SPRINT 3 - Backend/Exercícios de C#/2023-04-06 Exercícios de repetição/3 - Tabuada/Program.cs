// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.
Console.WriteLine($"Informe um número:");
float numero = float.Parse(Console.ReadLine());

for (int multiplo = 0; multiplo < 10; multiplo += 1){
    Console.WriteLine($"{numero}x{multiplo} = {numero * multiplo}");
}