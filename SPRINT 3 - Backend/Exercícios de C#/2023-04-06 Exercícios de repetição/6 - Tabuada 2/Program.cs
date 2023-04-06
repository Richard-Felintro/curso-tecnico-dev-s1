// 6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

// Exemplo: tabuada do 1, tabuada do 2, etc...
// Dica: utilize um laço dentro do outro.
for (int numero = 1; numero <= 10; numero++){
    Console.WriteLine($@"Tabuada de {numero}
    ");
for (int multiplo = 1; multiplo <= 10; multiplo++){
    Console.WriteLine($"{numero} * {multiplo} = {numero*multiplo}");
}
}