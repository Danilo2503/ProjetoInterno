using Carometro.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carometro.webApi.Interfaces
{
    interface ITurmaRepository
    {
        void Cadastrar(Turma novaTurma);

        void Atualizar(int id, Turma turmaAtualizada);

        void Deletar(int id);

        List<Turma> Listar();
    }
}
