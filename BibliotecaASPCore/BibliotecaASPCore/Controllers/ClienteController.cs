using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaASPCore.Contexto;
using BibliotecaASPCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaASPCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly BibliotecaContexto bibliotecaContexto;


        public ClienteController(BibliotecaContexto bibliotecaContexto)
        {
            this.bibliotecaContexto = bibliotecaContexto;
        }


        public ActionResult Index()
        {
            return View(bibliotecaContexto.Clientes.ToList());
        }

        [HttpGet]
        public ActionResult Cliente()
        {

            return View(bibliotecaContexto.Clientes.ToList());
        }

        [HttpGet]
        [Route("CadastroCliente")]
        public ActionResult CadastroCliente()
        {
            return View("CadastroCliente");
        }

        [HttpPost]
        [Route("CadastroCliente")]
        public ActionResult CadastroCliente([FromForm]Cliente cliente)
        {
            bibliotecaContexto.Clientes.Add(cliente);
            bibliotecaContexto.SaveChanges();
            return View();
        }

        [HttpGet]
        [Route("DetalharCliente")]
        public ActionResult DetalharCliente(int id)
        {
            var cliente = bibliotecaContexto.Clientes.FirstOrDefault(x => x.Id == id);
            if (cliente == null) return NotFound();
            return View(cliente);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var cliente = bibliotecaContexto.Clientes.Find(id);
            bibliotecaContexto.Remove(cliente);
            bibliotecaContexto.SaveChanges();
            return RedirectToAction("Cliente");
        }


        [HttpGet]
        [Route("EditarCliente/{id}")]
        public ActionResult EditarCliente(int id)
        {
            return View("EditarCliente", bibliotecaContexto.Clientes.Find(id));
        }

        [HttpPost]
        [Route("EditarCliente/{id?}")]
        public ActionResult EditarCliente(int id, [FromForm]Cliente cliente)
        {
            bibliotecaContexto.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            bibliotecaContexto.SaveChanges();
            return View();
        }
    }
}