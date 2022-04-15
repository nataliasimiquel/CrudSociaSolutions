using SocialSolucions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Repositorio
{
  public interface IClienteRepositorio
    {
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
    }
}
