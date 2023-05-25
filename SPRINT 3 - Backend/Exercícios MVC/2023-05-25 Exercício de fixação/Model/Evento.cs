using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_de_fixacao.Model
{
    public class Evento
    {
        //* Propriedades dos eventos
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }

        //* Caminho de arquivo
        private const string path = "Data/Eventos.csv";

        //* Construtor
        public Evento()
        {
            string caminhoData = path.Split("/")[0];

            //* Verifica se a pasta Data existe, se não, cria ela
            if (!Directory.Exists(caminhoData))
            {
                Directory.CreateDirectory(caminhoData);
            }

            //* Verifica se o arquivo Eventos.csv existe, se não, cria ele
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        //* Transforma a lista em string
        public string PrepararLinhas(Evento e)
        {
            return $"{e.Nome};{e.Data};{e.Descricao}";
        }

        public void Inserir(Evento e)
        {
            string[] linhas = { PrepararLinhas(e) };
            File.AppendAllLines(path, linhas);
        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();
            string[] linhas = File.ReadAllLines(path);
            
            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");
                Evento p = new Evento();
                p.Nome = atributos[0];
                p.Data = DateTime.Parse(atributos[1]);
                p.Descricao = atributos[2];
                eventos.Add(p);
            }
            return eventos;
        }
    }
}