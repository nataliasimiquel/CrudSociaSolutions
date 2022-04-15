using Microsoft.EntityFrameworkCore;
using SocialSolucions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> Options) : base(Options)
        {
        }

    public DbSet<ClienteModel> Cliente { get; set; }
    public DbSet<ImovelModel> Imovel { get; set; }

    }
}
