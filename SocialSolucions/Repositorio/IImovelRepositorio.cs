using SocialSolucions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Repositorio
{
    interface IImovelRepositorio
    {
        List<ImovelModel> BuscarTodos();
        ImovelModel Adicionar(ImovelModel imovel);
    }
}
