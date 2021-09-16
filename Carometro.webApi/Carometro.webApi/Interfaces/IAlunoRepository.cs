using Carometro.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carometro.webApi.Interfaces
{
    interface IAlunoRepository
    {
        void Cadastrar(Aluno novoAluno);

        void Deletar(int id);

        void Atualizar(int id, Aluno alunoAtualizado);

        List<Aluno> ListarTodos();
    }
}
