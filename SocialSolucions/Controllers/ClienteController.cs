using Microsoft.AspNetCore.Mvc;
using SocialSolucions.Models;
using SocialSolucions.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolucions.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ClienteModel cliente =
            _clienteRepositorio.ListarPorId(id);

            return View(cliente);
        }
        public IActionResult Excluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ClienteModel cliente)
        {
            _clienteRepositorio.Adicionar(cliente);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar (ClienteModel cliente)
        {
            _clienteRepositorio.Editar(cliente);

            return RedirectToAction("Index");
        }
    }
}
