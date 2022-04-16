using SocialSolucions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Repositorio
{
    interface IImovelRepositorio
    {
        ClienteModel ListarPorId(int id);
        List<ImovelModel> BuscarTodos();
        ImovelModel Adicionar(ImovelModel imovel);
        ImovelModel Editar(ImovelModel imovel);
        bool ExcluirConfirmacao(int id);
    }
}
