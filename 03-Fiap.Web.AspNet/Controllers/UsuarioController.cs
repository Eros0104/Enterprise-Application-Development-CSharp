using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_Fiap.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult UsuarioCadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UsuarioCadastrar(Usuario usuario)
        {
            ViewBag.usuario = usuario.Name;
            ViewData["data"] = usuario.DataNascimento;
            TempData["msg"] = "sucesso!";
            return View(usuario);
        }
    }
}