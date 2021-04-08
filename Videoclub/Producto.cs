using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoclub
{
    public class Producto
    {
        protected int Codigo;
        protected string Descripcion;
        protected double Precio;

        public Producto(int codigo, string descripcion, double precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
        }

        public int MCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public double MPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        public string MDescripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
    }
}
