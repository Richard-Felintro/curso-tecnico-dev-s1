using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrato_de_negocio
{
    public interface IAgenda
    {
        public void Adicionar(Contato contato_);
        public void Listar();
    }
}