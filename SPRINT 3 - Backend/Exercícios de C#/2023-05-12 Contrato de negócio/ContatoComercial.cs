using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrato_de_negocio
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj;
        public bool ValidarCnpj(string cnpj_)
        {
            if (cnpj_.All(char.IsDigit))
            {
                if (cnpj_.Length == 14)
                {
                    return true;
                }
            }
            return false;
        }
    }
}