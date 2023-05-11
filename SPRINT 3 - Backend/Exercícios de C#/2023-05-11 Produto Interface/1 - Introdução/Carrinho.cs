using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        //* PROPRIEDADES
        public float Valor { get; set; }

        //* Criar uma lsita para manipular os nossos objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Listar()
        {
            if (carrinho.Any())
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"{p.Codigo} : {p.Nome} : {p.Preco:C2}");
                }
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }
        public void CalcularTotal()
        {
            Valor = 0;
            if (carrinho.Any())
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }
                Console.WriteLine($"\nO total de seu carrinho é {Valor:C2}\n");
            }
            else
            {
                Console.WriteLine($"\nSeu carrinho está vazio\n");
            }
        }
    }
}
