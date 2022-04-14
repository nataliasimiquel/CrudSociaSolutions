using ImobiliariaSocialSolucions.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiliariaSocialSolucions.Controllers
{
    public class ImovelController : Controller
    {
        public IActionResult Index()
        {
            ClienteImovelModel imovel = new ClienteImovelModel();

            imovel.Descrição = "Imovel de luxo";
            imovel.Valor = "R$ 1.800.000,00";

            return View(imovel);
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
