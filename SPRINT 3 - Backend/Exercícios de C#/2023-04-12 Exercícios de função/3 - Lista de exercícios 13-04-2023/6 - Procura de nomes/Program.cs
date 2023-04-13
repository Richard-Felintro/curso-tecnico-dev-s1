string[] nomes = new string[10];
for (var i = 0; i <= 9; i++)
{
    Console.WriteLine($"Informe um nome:");
    nomes[i] = Console.ReadLine();
}

bool desejaContinuar = true;
while (desejaContinuar == true)
{
    Console.WriteLine($"Informe um nome a ser procurado:");
    bool nomeAchado = false;
    string nomeProcurado = Console.ReadLine();
    for (var i = 0; i < 9; i++)
    {
        if (nomes[i].ToLower() == nomeProcurado.ToLower())
        {
            Console.WriteLine($"Nome '{nomeProcurado}' achado na posição {i + 1} na lista");
            nomeAchado = true;
        }
    }
    if (nomeAchado == false)
    {
        Console.WriteLine($"Nome '{nomeProcurado}' não achado na lista.");
    }
continuar:
    Console.WriteLine($@"Deseja procurar outro nome?
[N] Não
[S] Sim");
    string continuar = Console.ReadLine().ToUpper();
    switch (continuar)
    {
        case "N":
            desejaContinuar = false;
            break;
        case "S":
            desejaContinuar = true;
            break;
        default:
            Console.WriteLine($"VALOR INVÁLIDO");
            goto continuar;
    }
}

// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.