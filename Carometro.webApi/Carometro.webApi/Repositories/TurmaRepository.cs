using Carometro.webApi.Contexts;
using Carometro.webApi.Domains;
using Carometro.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carometro.webApi.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        CarometroContext ctx = new CarometroContext();

        public void Atualizar(int id, Turma turmaAtualizada)
        {
            Turma turmaBuscada = ctx.Turmas.Find(id);

            if (turmaAtualizada.Nome != null)
            {
                turmaBuscada.Nome = turmaAtualizada.Nome;
            }

            if (turmaAtualizada.IdTurma != 0)
            {
                turmaBuscada.IdTurma = turmaAtualizada.IdTurma;
            }

            ctx.Turmas.Update(turmaAtualizada);

            ctx.SaveChanges();
        }

        public void Cadastrar(Turma novaTurma)
        {
            ctx.Turmas.Add(novaTurma);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Turma turmaBuscada = ctx.Turmas.Find(id);

            ctx.Turmas.Remove(turmaBuscada);

            ctx.SaveChanges();
        }

        public List<Turma> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
