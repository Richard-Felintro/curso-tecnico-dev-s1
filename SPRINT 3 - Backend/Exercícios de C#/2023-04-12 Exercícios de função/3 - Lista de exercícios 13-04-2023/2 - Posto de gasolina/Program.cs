static float CalculoAlcool (float preco){
    if (preco <= 20){
        return 4.9F*0.97F;
    }
    else{
    return 4.9F*0.95F;
    }
}
static float CalculoGasosa (float preco){
    if (preco <= 20){
        return 5.3F*0.96F;
    }
    else{
    return 5.3F*0.92F;
    }
}

escolhaCompra:
Console.WriteLine($@"Escolha o seu combustível:
[A] Álcool
[G] Gasolina");
string escolhaCompra = Console.ReadLine().ToUpper();
if (escolhaCompra != "A" && escolhaCompra != "G") { }
else
{
    Console.WriteLine($"~+~+~ ESCOLHA INVÁLIDA ~+~+~");
    goto escolhaCompra;
}
Console.WriteLine($"Informe quantos litros deseja comprar:");
float preco = float.Parse(Console.ReadLine());
float litros = preco;
if (escolhaCompra == "A"){
    Console.WriteLine($"O custo de {litros} de álcool será R${Math.Round(CalculoAlcool(preco),2)}");
}
else{
    Console.WriteLine($"O custo de {litros} de gasolina será R${Math.Round(CalculoGasosa(preco),2)}");
}

// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.