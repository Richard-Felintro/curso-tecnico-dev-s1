using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_MVC.Model
{
    public class Produto
    {
        //* Propriedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //* Caminho da pasta e arquivo CSV
        private const string PATH = "Database/Produto.csv";

        //* Construtor
        public Produto()
        {
            //* Criar a lógica para gerar a pasta e o arquivo

            //*   Obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            //*   Verificar se no caminho já existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //*   Verificar se no caminho já existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        //* Retorna a lista de produtos para ser lida
        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");
                Produto p = new Produto();
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);
                produtos.Add(p);
            }
            return produtos;
        }
        //* Preparar as linhas para serem inseridas no CSV
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco:c2}";
        }

        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};
            File.AppendAllLines(PATH, linhas);
        }
    }
}