using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_gamer_fullstack.Models
{
    public class Jogador
    {
        //* Propriedades
        [Key]
        public int IdJogador { get; set; }
        public string? Nome  { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        [ForeignKey("Equipe")]
        public int IdEquipe  { get; set; }
        public Equipe Equipe { get; set;}

        //* Métodos
        // public void Cadastrar(Jogador j){}
        // public List<Jogador> Listar(){}
        // public void Excluir(int id){}
        // public void Atualizar(Jogador j){}
    }
}