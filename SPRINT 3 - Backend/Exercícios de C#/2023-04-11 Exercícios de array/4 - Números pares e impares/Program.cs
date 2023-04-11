int[] numeros = new int[6];
int pares = 0;
int impares = 0;
for (var i = 0; i < 6; i++)
{
    Console.WriteLine($"Informe um valor: ");
    numeros[i] = int.Parse(Console.ReadLine());
}
foreach (var numero in numeros)
{
    if (numero % 2 == 0){
        pares++;
    }
    else{
        impares++;
    }
}
Console.WriteLine($"Quantidade de valores pares: {pares}");
Console.WriteLine($"Quantidade de valores impares: {impares}");