using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaASPCore.Contexto;
using BibliotecaASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BibliotecaASPCore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : Controller
    {
        private readonly BibliotecaContexto bibliotecaContexto;

        public EmprestimoController(BibliotecaContexto bibliotecaContexto)
        {
            this.bibliotecaContexto = bibliotecaContexto;
        }


        public ActionResult Index()
        {
            return View(bibliotecaContexto.Emprestimos.ToList());
        }

        [HttpGet]
        public ActionResult Emprestimo()
        {
            ViewBag.IdCliente = this.bibliotecaContexto.Clientes.ToList().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id.ToString()
            }).ToList();
            ViewBag.IdLivro = this.bibliotecaContexto.Livros.ToList().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id.ToString()
            }).ToList();
            return View(bibliotecaContexto.Emprestimos.ToList());
        }

        [HttpGet]
        [Route("CadastroEmprestimo")]
        public ActionResult CadastroEmprestimo()
        {
            ViewBag.IdCliente = this.bibliotecaContexto.Clientes.ToList().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id.ToString()
            }).ToList();
            ViewBag.IdLivro = this.bibliotecaContexto.Livros.ToList().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id.ToString()
            }).ToList();
            return View("CadastroEmprestimo");
        }

        [HttpPost]
        [Route("CadastroEmprestimo")]
        public ActionResult CadastroEmprestimo([FromForm]Emprestimo emprestimo)
        {

 
            emprestimo.DataAluguel = DateTime.Now;

            bibliotecaContexto.Emprestimos.Add(emprestimo);
            var status = bibliotecaContexto.Livros.SingleOrDefault(x => x.Id == emprestimo.IdLivro);

            if (status.Status == Models.Fixo.Status.Alugado)
            {
                return NotFound();
            }

            if(emprestimo.DataEntrega < emprestimo.DataAluguel)
            {
                return NoContent();
            }

            if (status != null)
            {
                status.Status = Models.Fixo.Status.Alugado;
                bibliotecaContexto.SaveChanges();
            }
            bibliotecaContexto.SaveChanges();

            return View();
        }

        [HttpGet]
        [Route("DevolverLivro/{id}")]
        public ActionResult DevolverLivro(int id)
        {

            var emprestimo = bibliotecaContexto.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimo == null) return NoContent();

            var status = bibliotecaContexto.Livros.SingleOrDefault(x => x.Id == emprestimo.IdLivro);
            if (status != null)
            {
                status.Status = Models.Fixo.Status.Disponivel;
                bibliotecaContexto.SaveChanges();
            }

            bibliotecaContexto.Emprestimos.Remove(emprestimo);
            bibliotecaContexto.SaveChanges();
            return RedirectToAction("Emprestimo");
        }




    }
}