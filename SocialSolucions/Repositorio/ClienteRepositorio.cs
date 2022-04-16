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

        ClienteModel IClienteRepositorio.ListarPorId(int id)
        {
            //throw new NotImplementedException();
            return _bancoContext.Cliente.FirstOrDefault(x =>x.Id ==id);
        }
        

        private ClienteModel ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public ClienteModel Editar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);

            if (cliente == null) throw new SystemException("Erro na atualização");

            clienteDB.Status = cliente.Status;
            clienteDB.Nome = cliente.Nome;
            clienteDB.Email = cliente.Email;
            clienteDB.CPF = cliente.CPF;

            _bancoContext.Cliente.Update(clienteDB);
            _bancoContext.SaveChanges();

            // throw new NotImplementedException()

            throw new NotImplementedException();
        }

        public bool ExcluirConfirmacao(int id)
        {
            ClienteModel clienteDB = ListarPorId(id);

            if (clienteDB == null) throw new SystemException("Erro");
            // throw new NotImplementedException();
            _bancoContext.Cliente.Remove(clienteDB);
            _bancoContext.SaveChanges();
            return true;

        }
    }
}
