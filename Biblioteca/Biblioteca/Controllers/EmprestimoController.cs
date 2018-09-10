using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Contexto;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Controllers
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

        [HttpGet]
        public IActionResult GetAll()
        {   

            var emprestimos = bibliotecaContexto.Emprestimos.ToList();

            return Ok(emprestimos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Emprestimo emprestimo)
        {
            
            emprestimo.DataAluguel = DateTime.Now;
            emprestimo.DataEntrega = DateTime.Now;
            
            bibliotecaContexto.Emprestimos.Add(emprestimo);
            var status = bibliotecaContexto.Livros.SingleOrDefault(x => x.Id == emprestimo.IdLivro);
            if(status != null)
            {
                status.Status =Models.Fixo.Status.alugado;
                bibliotecaContexto.SaveChanges();
            }
            bibliotecaContexto.SaveChanges();
         
            return Ok(bibliotecaContexto.Emprestimos.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var emprestimo  = bibliotecaContexto.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimo == null) return NoContent();
      
            var status = bibliotecaContexto.Livros.SingleOrDefault(x => x.Id == emprestimo.IdLivro);
            if (status != null)
            {
                status.Status = Models.Fixo.Status.disponivel;
                bibliotecaContexto.SaveChanges();
            }
           
            bibliotecaContexto.Emprestimos.Remove(emprestimo);
            bibliotecaContexto.SaveChanges();
            return Ok(bibliotecaContexto.Emprestimos.ToList());
        }
    }
}