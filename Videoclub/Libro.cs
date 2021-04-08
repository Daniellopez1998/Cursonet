using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoclub
{
    public class Libro:Producto
    {
        private string Autor;
        private string Isbn;

        public Libro(int codigo, string descripcion, double precio, string autor, string isbn):base(codigo, descripcion, precio)
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
