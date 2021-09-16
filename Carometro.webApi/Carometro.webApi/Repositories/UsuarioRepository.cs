using Carometro.webApi.Contexts;
using Carometro.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carometro.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        CarometroContext ctx = new CarometroContext();

        public void Cadastrar(UsuarioRepository novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }
    }
}
