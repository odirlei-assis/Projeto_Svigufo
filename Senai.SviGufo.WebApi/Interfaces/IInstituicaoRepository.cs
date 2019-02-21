using Senai.SviGufo.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SviGufo.WebApi.Interfaces
{
    public interface IInstituicaoRepository
    {

        List<InstituicaoDomain> Listar();

        void Cadastrar(InstituicaoDomain instituicao);

        void Alterar(int id, InstituicaoDomain instituicao);

        void Deletar(int id);

        InstituicaoDomain BuscarPorId(int id);
    }
}
