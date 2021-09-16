using Carometro.webApi.Contexts;
using Carometro.webApi.Domains;
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

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            if(usuarioAtualizado.Nome != null)
            {
                usuarioBuscado.Nome = usuarioAtualizado.Nome;
            }

            if(usuarioAtualizado.Email != null)
            {
                usuarioBuscado.Email = usuarioAtualizado.Email;
            }

            if(usuarioAtualizado.Senha != null)
            {
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }

            if (usuarioAtualizado.IdTipoUsuario != 0)
            {
                usuarioBuscado.IdTipoUsuario = usuarioAtualizado.IdTipoUsuario;
            }

            ctx.Usuarios.Update(usuarioAtualizado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario

            .include(m => m.idSalaNavigation)

            .Select(m => new Usuario
            {
                IdUsuario = m.IdUsuario,
                Nome = m.Nome,

                IdTipoUsuarioNavigation = new TipoUsuario
            {
                IdTipoUsuario = m.IdTipoUsuarioNavigation.IdTipoUsuario,
                Nome = m.IdTipoUsuarioNavigation.Nome
            }

            })
                .ToList();
        }
    }
}
