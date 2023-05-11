using Produto_Interface;

Console.Clear();

//* Instância do objeto carrinho
Carrinho carrinho = new Carrinho();

//* Instanciar objetos da classe produto
Produto p1 = new Produto(1, "Grande Furto Automático 6", 999.99F);
Produto p2 = new Produto(2, "Diadema vire gente", 8.99F);
Produto p3 = new Produto(3, "Fusca Horizonte 6", 99.99F);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();
carrinho.CalcularTotal();

Console.WriteLine($"Depois da remoção de um item.");

carrinho.Remover(p2);

carrinho.Listar();
carrinho.CalcularTotal();

//*Criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "FIFA 1853";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1,_novoProduto);

carrinho.Listar();
carrinho.CalcularTotal();