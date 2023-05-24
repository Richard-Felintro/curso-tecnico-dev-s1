using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicios_MVC.Model;

namespace Exercícios_MVC.View
{
    public class ProdutoView
    {
        //* Método para exibir dados da lista
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"Nome   : {item.Nome}");
                Console.WriteLine($"Preço  : {item.Preco:C2}\n");
            }
        }
    }
}