using Carometro.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carometro.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(Usuario novoUsuario);

        void Deletar(int id);

        void Atualizar(Usuario usuarioAtualizado);

        List<Usuario> Listar();
    }
}
