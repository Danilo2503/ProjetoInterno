using System;
using System.Collections.Generic;

#nullable disable

namespace Carometro.webApi.Domains
{
    public partial class Turma
    {
        public Turma()
        {
            Alunos = new HashSet<Aluno>();
        }

        public int IdTurma { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
