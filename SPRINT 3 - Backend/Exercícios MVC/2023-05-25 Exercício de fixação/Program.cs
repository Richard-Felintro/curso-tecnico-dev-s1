//* Criar um programa console Para cadastro de Evento. Aplique os conceitos MVC aprendidos em sala de aula.
//* O evento deve ter Nome, Descrição e Data que o evento ocorrerá.
//* As funcionalidades devem ser Cadastrar e Listar.
using Exercicio_de_fixacao.Controller;
using Exercicio_de_fixacao.Model;
using Exercicio_de_fixacao.View;

Evento evento = new Evento();
EventoController control = new EventoController();
bool Loop = true;
while (Loop)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Gerenciador de eventos");
    Console.ResetColor();
    Console.WriteLine("Menu inicial");
    Console.WriteLine($"[1] Cadastrar evento");
    Console.WriteLine($"[2] Listar eventos");
    string inicioInput = Console.ReadLine()!;
    switch (inicioInput)
    {
        case "1":
            control.CadastrarEvento();
            break;
        case "2":
            control.ListarEventos();
            break;
    }
}