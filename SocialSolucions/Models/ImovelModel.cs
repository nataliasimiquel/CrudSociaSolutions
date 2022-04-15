using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Models
{
    public class ImovelModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string TipodeNegócio { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
    }
}
