using Carometro.webApi.Contexts;
using Carometro.webApi.Domains;
using Carometro.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carometro.webApi.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        CarometroContext ctx = new CarometroContext();

        public void Cadastrar(Aluno novoAluno)
        {
            ctx.Alunos.Add(novoAluno);

            ctx.SaveChanges();
        }

        public List<Aluno> ListarTodos()
        {
            return ctx.Aluno

            .include(m => m.idSalaNavigation)

            .Select(m => new Aluno
            {
                IdAluno = m.IdAluno,
                Nome = m.Nome,

                IdTurmaNavigation = new Turma
                {
                    IdTurma = m.IdTurmaNavigation.IdTurma,
                    Nome = m.IdTurmaNavigation.Nome
                }

            })
            .ToList();
        }

        public void Atualizar(int id, Aluno alunoAtualizado)
        {
            Aluno alunoBuscado = ctx.Aluno.Find(id);

            if (alunoAtualizado.IdAluno != 0)
            {
                alunoBuscado.IdAluno = alunoAtualizado.IdAluno;
            }
            if (alunoAtualizado.Nome != null)
            {
                alunoBuscado.Nome = alunoAtualizado.Nome;
            }
            if (alunoAtualizado.IdTurma != 0)
            {
                alunoBuscado.IdTurma = alunoAtualizado.IdTurma;
            }
                ctx.Alunos.Update(alunoAtualizado);

                ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Aluno alunoBuscado = ctx.Aluno.Find(id);

            ctx.Alunos.Remove(alunoBuscado);

            ctx.SaveChanges();
        }
    }
}
