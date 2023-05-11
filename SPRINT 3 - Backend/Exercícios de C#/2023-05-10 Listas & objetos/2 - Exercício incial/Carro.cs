using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCarro
{
    public class Carro
    {
        public string Marca;
        public string Cor;
        public Carro() { }
        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;
        }
    }
}