using SocialSolucions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Repositorio
{
  public interface IClienteRepositorio
    {
        ClienteModel ListarPorId(int id);
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
        ClienteModel Editar(ClienteModel cliente);
        bool ExcluirConfirmacao(int id);


    }
}
