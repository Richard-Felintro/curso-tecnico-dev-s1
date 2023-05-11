using ClasseProduto;
Console.Clear();
Console.WriteLine($"Informe o código do produto:");
int codigoInput = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Informe o nome do produto:");
string nomeInput = Console.ReadLine()!;
Console.WriteLine($"Informe o preço do produto:");
float precoInput = int.Parse(Console.ReadLine()!);

List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto(codigoInput, nomeInput, precoInput));

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);