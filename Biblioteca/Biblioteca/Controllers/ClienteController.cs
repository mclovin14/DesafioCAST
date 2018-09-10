using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Contexto;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
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

        [HttpGet]
        public IActionResult GetAll()
        {
            var clientes = bibliotecaContexto.Clientes.ToList();

            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {

            bibliotecaContexto.Clientes.Add(cliente);

            bibliotecaContexto.SaveChanges();

            return Ok(bibliotecaContexto.Clientes.ToList());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = bibliotecaContexto.Clientes.FirstOrDefault(x => x.Id == id);

            if (cliente != null)
            {
                bibliotecaContexto.Remove(cliente);
                bibliotecaContexto.SaveChanges();
                return Ok(bibliotecaContexto.Clientes.ToList());

            }
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = bibliotecaContexto.Clientes.FirstOrDefault(x => x.Id == id);

            if (cliente == null) return NoContent();

            return Ok(cliente);
        }

    }
}