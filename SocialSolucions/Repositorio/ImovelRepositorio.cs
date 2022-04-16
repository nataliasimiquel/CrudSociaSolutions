using SocialSolucions.Data;
using SocialSolucions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Repositorio
{
    public class ImovelRepositorio : IImovelRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ImovelRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }

       

        ImovelModel IImovelRepositorio.Adicionar(ImovelModel imovel)
        {
            _bancoContext.Imovel.Add(imovel);

            _bancoContext.SaveChanges();

            return imovel;

          //  throw new NotImplementedException();
        }
        List<ImovelModel> IImovelRepositorio.BuscarTodos()
        {
            // throw new NotImplementedException();
            return _bancoContext.Imovel.ToList();
        }
        ClienteModel IImovelRepositorio.ListarPorId(int id)
        {
            //throw new NotImplementedException();
            return _bancoContext.Cliente.FirstOrDefault(x => x.Id == id);
        }
        public ImovelModel ListarPorId(int id)
        {
            throw new NotImplementedException();
        }
        public ImovelModel Editar(ImovelModel imovel)
        {
            ImovelModel imovelDB = ListarPorId(imovel.Id);

            if (imovel == null) throw new SystemException("Erro na atualização");

            imovelDB.Status = imovel.Status;
            imovelDB.TipodeNegócio = imovel.TipodeNegócio;
            imovelDB.Valor = imovel.Valor;
            imovelDB.Descricao = imovel.Descricao;

            _bancoContext.Imovel.Update(imovel);
            _bancoContext.SaveChanges();

            // throw new NotImplementedException()

            throw new NotImplementedException();

            // throw new NotImplementedException();
        }

        public bool ExcluirConfirmacao(int id)
        {
            ImovelModel imovelDB = ListarPorId(id);

            if (imovelDB == null) throw new SystemException("Erro");
            _bancoContext.Imovel.Remove(imovelDB);
            _bancoContext.SaveChanges();
            return true;
            //throw new NotImplementedException();
        }
    }
}
