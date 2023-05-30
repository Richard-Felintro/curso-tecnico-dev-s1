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
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        Context c = new Context(); //* Instância Context que acessa o banco de dados

        [Route("Listar")]//*http:/localhost/Equipe/Listar
        public IActionResult Index()
        {
            ViewBag.Equipe = c.Equipe.ToList(); //* "Mochila" que contém equipes. 
            return View(); //* Esta "mochila" pode ser usada no View de equipe.
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.Nome = form["Nome"].ToString();
            novaEquipe.Imagem = form["Imagem"].ToString();

            c.Equipe.Add(novaEquipe);
            c.SaveChanges();

            ViewBag.Equipe = c.Equipe.ToList();

            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}