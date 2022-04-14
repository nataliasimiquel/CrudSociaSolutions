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

            return View();
        }
       
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }


    }
}
