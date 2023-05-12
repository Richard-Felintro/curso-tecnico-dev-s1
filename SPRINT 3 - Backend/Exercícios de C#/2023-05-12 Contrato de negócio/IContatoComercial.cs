using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrato_de_negocio
{
    public interface IContatoComercial
    {
        public bool ValidarCnpj(string cnpj_);
    }
}