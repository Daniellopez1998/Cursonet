using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciasmartes2
{
    class Estudainte : Personas
    {
        private int intCalificacion;
        public int Calificacion {get; set;}
        public string Estudiar()
        {
            return "esta estudiando...";
        }
    }
}
