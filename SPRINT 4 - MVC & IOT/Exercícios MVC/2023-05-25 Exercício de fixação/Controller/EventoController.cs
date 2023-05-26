using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_de_fixacao.Model;
using Exercicio_de_fixacao.View;

namespace Exercicio_de_fixacao.Controller
{
    public class EventoController
    {
        Evento model = new Evento();
        EventoView view = new EventoView();
        EventoController control = new EventoController();

        public void GerarMenuInicial()
        {
            string input = view.TelaInicial();
            if (input == "1") { CadastrarEvento(); }
            if (input == "2") { ListarEventos(); }
        }
        public void CadastrarEvento()
        {
            model.Inserir(view.Cadastrar());
        }
        public void ListarEventos()
        {
            List<Evento> eventos = model.Ler();
            view.Listar(eventos);
        }
    }
}