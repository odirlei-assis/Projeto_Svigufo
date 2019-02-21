using Senai.SviGufo.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SviGufo.WebApi.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(UsuarioDomain usuario);

        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}
