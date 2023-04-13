float desconto = 0;
Console.WriteLine($"Informe o nome do produto:");
string nomeProduto = Console.ReadLine();
Console.WriteLine($"Informe quantas unidades deseja adiquirir:");
quantidade:
int quantidade = int.Parse(Console.ReadLine());
if (quantidade < 1)
{
    Console.WriteLine($"~+~+~ QUANTIDADE INVÁLIDA ~+~+~");
    goto quantidade;
}
Console.WriteLine($"Informe o preço unitário do produto:");
float precoUnitario = float.Parse(Console.ReadLine());
if (quantidade <= 5)
{
    desconto = 0.02F;
}
else if (quantidade > 5 && quantidade <= 10)
{
    desconto = 0.03F;
}
else
{
    desconto = 0.05F;
}
Console.WriteLine($"O preço de {quantidade} unidades de {nomeProduto} será R${Math.Round(precoUnitario*quantidade*(1-desconto))}");

// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else