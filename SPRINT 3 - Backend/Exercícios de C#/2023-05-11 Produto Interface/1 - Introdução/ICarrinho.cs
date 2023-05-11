using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public interface ICarrinho
    {
        //* Regras do contrato
        //* Métodos, devem ser apenas declarados

        //* CRUD: Create, read, update, delete

        //* Tipo Nome(parametros)

        //* Create
        void Adicionar(Produto _produto);

        //* Read
        void Listar();

        //* Update
        void Atualizar(int _codigo, Produto _produto);
        
        //* Delete
        void Remover(Produto _produto);
    }
}