using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_videoclub
{
  class Libro : Producto {
        private string Autor;
        private string Isbn;
        public Libro(int codigo, double precio, string descripcion, string autor, string isbn) : base(codigo, precio, descripcion)
        {
            Autor = autor;
            Isbn = isbn;
        }
        public string MAutor
        {
            get { return Autor; }
            set { Autor = value; }
        }
        public string MIsbn
        {
            get { return Isbn; }
            set { Isbn = value; }
        }

    }
}
