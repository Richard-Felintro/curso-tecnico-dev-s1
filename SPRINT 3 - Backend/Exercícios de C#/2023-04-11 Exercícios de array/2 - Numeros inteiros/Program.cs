int[] numeros = new int[5];
for (var i = 0; i < 5; i++) {
    Console.WriteLine($"Informe um número inteiro:");
    numeros[i] = int.Parse(Console.ReadLine());
}
foreach (var numero in numeros) {
    Console.WriteLine($"O dobro de {numero} é {numero * 2}");
}