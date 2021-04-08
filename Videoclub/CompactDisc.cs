using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoclub
{
    public class CompactDisc:Producto
    {
        private string Artista;
        private string Discografia;

        public CompactDisc (int codigo, string descripcion, double precio, string artista, string discografia):base(codigo, descripcion, precio)
        {
            Artista = artista;
            Discografia = discografia;
        }

        public string MArtista
        {
            get { return Artista; }
            set { Artista = value; }
        }
        public string MDiscografia
        {
            get { return Discografia; }
            set { Discografia = value; }
        }
    }
}
