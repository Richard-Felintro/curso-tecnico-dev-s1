// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

float nota = -1F;
while (nota < 0 || nota > 10){
    Console.WriteLine($"Informe uma nota");
    nota = float.Parse(Console.ReadLine());
    Console.WriteLine($"Valor inválido");
}
Console.WriteLine($"Valor válido");