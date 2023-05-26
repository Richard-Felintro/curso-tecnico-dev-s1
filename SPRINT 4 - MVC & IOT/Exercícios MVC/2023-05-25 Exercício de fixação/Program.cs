//* Criar um programa console Para cadastro de Evento. Aplique os conceitos MVC aprendidos em sala de aula.
//* O evento deve ter Nome, Descrição e Data que o evento ocorrerá.
//* As funcionalidades devem ser Cadastrar e Listar.
using Exercicio_de_fixacao.Controller;
using Exercicio_de_fixacao.Model;
using Exercicio_de_fixacao.View;

Evento evento = new Evento();
EventoController control = new EventoController();
control.GerarMenuInicial();