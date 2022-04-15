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
    }
}
