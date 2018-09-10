using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Contexto;
using Biblioteca.Models;
using Biblioteca.Models.Fixo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        private readonly BibliotecaContexto bibliotecaContexto;

        public LivroController(BibliotecaContexto bibliotecaContexto)
        {
            this.bibliotecaContexto = bibliotecaContexto;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
     
            
            var livros = bibliotecaContexto.Livros.ToList();

            return Ok(livros);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {

            bibliotecaContexto.Livros.Add(livro);

            bibliotecaContexto.SaveChanges();

            return Ok(bibliotecaContexto.Livros.ToList());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var livro = bibliotecaContexto.Livros.FirstOrDefault(x => x.Id == id);

            if (livro != null)
            {
                bibliotecaContexto.Remove(livro);
                bibliotecaContexto.SaveChanges();
                return Ok(bibliotecaContexto.Livros.ToList());

            }
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var livro = bibliotecaContexto.Livros.FirstOrDefault(x => x.Id == id);

            if (livro == null) return NoContent();

            return Ok(livro);
        }

    }
}