using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public Cliente Cliente { get; set; }

        public int IdLivro { get; set; }

        public Livro Livro { get; set; }

        public DateTime DataAluguel { get; set; }

        public DateTime DataEntrega { get; set; }


    }
}
