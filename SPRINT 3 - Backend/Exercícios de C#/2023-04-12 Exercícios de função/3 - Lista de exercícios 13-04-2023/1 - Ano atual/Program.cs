inicio:
Console.WriteLine($"Informe seu ano de nascimento:");
int anoNascimento = int.Parse(Console.ReadLine());
if (anoNascimento > DateTime.Now.Year){
    Console.WriteLine($"~+~+~ ANO DE NASCIMENTO INVÁLIDO ~+~+~");
    goto inicio;
}
if (DateTime.Now.Year - anoNascimento >= 16)
{
    Console.WriteLine($"Você pode legalmente votar!");
}
else
{
    Console.WriteLine($"Você não pode votar legalmente.");
}
// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).