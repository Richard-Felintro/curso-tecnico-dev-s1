using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer_fullstack.Infra;
using projeto_gamer_fullstack.Models;

namespace projeto_gamer_fullstack.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context(); //* Instância Context que acessa o banco de dados

        public IActionResult Index()
        {
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.IdEquipe = int.Parse(form["Equipe"]);
            novoJogador.Equipe = c.Equipe.First(x => x.IdEquipe == int.Parse(form["Equipe"]));
            novoJogador.Nome = form["JogadorNome"].ToString();
            novoJogador.Email = form["JogadorEmail"].ToString();
            novoJogador.Senha = form["JogadorSenha"].ToString();

            c.Jogador.Add(novoJogador);
            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }
        [Route("Editar")]

        [Route("Deletar")]
    }
}