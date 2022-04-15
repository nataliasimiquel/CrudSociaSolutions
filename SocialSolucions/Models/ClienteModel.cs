using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

    }
}
