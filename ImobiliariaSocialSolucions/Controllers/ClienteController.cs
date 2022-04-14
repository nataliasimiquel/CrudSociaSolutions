using ImobiliariaSocialSolucions.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiliariaSocialSolucions.Controllers
{
    public class ClienteController : Controller
    {

        public IActionResult Index()
        {
            ClienteModel cliente = new ClienteModel();

            cliente.Nome = "Natalia";

            cliente.Email = "Nat@NAT@nat";

            cliente.CPF = "000.000.000-00";

            return View();
        }
    }
}
