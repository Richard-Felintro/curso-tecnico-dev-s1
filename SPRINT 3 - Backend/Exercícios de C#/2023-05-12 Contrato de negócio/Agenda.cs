namespace Contrato_de_negocio
{
    public class Agenda : IAgenda
    {
        List<Contato> agendaContatos = new List<Contato>();

        public void Adicionar(Contato contato_)
        {
            agendaContatos.Add(contato_);
        }

        public void Listar()
        {
            List<ContatoPessoal> pessoal = new List<ContatoPessoal>();
            List<ContatoComercial> comercial = new List<ContatoComercial>();
            if (agendaContatos.Any())
            {
                foreach (var c in agendaContatos)
                {
                    if (c is ContatoPessoal)
                    {
                        pessoal.Add((ContatoPessoal)c);
                    }
                    else
                    {
                        comercial.Add((ContatoComercial)c);
                    }
                }

                Console.WriteLine($"CONTATOS PESSOAIS");
                foreach (var c in pessoal)
                {
                    Console.WriteLine($"Nome : {c.Nome}");
                    Console.WriteLine($"Telefone : {c.Telefone}");
                    Console.WriteLine($"Email : {c.Email}");
                    Console.WriteLine($"CPF : {c.Cpf}\n");
                }
                Console.WriteLine($"CONTATOS COMERCIAIS");
                foreach (var c in comercial)
                {
                    Console.WriteLine($"Nome : {c.Nome}");
                    Console.WriteLine($"Telefone : {c.Telefone}");
                    Console.WriteLine($"Email : {c.Email}");
                    Console.WriteLine($"CNPJ : {c.Cnpj}\n");
                }
                Console.Write($"Aperte ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}