using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba2
{
    public class Libro
    {
        public string ISBN;
        public string Titulo;
        public string Escritor;

        public string Alquilar()
        {
            return "ALQUILADO";
        }

        public string Vender()
        {
            return "LIBRO VENDIDO";
        }
    }
}