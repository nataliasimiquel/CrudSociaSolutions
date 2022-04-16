using Microsoft.AspNetCore.Mvc;
using SocialSolucions.Models;
using SocialSolucions.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Controllers
{
    public class ImovelController : Controller
    {
        private readonly IImovelRepositorio _imovelRepositorio;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
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
        public IActionResult ExcluirConfirmacao(int id)
        {
           // _clienteRepositorio.ExcluirConfirmacao(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Criar(ImovelModel cliente)
        {
            _imovelRepositorio.Adicionar(cliente);

            return RedirectToAction("Index");
        }
        [HttpPost] 
        public IActionResult Editar(ImovelModel cliente)
        {
            _imovelRepositorio.Editar(cliente);

            return RedirectToAction("Index");
        }
    }
}
