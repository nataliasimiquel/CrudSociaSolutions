using SocialSolucions.Data;
using SocialSolucions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        ClienteModel IClienteRepositorio.Adicionar(ClienteModel cliente)
        {
            /*throw new NotImplementedException();*/
            //Gravar no banco de dados
            _bancoContext.Cliente.Add(cliente);

            _bancoContext.SaveChanges();

            return cliente;
        }

        List<ClienteModel> IClienteRepositorio.BuscarTodos()
        {
            // throw new NotImplementedException();
            return _bancoContext.Cliente.ToList();
        }
    }
}
