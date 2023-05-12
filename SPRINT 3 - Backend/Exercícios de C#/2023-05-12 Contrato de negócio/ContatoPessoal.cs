using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrato_de_negocio
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf;

        public bool ValidarCpf(string cpf_)
        {
            if (cpf_.All(char.IsDigit))
            {
                if (cpf_.Length == 11)
                {
                    return true;
                }
            }
            return false;
        }
    }
}