using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciasmartes2
{
    class Profesor:Personas
    {
        private double dlbSueldo;
        public double Sueldo { get; set; }
        public string Enseñar()
        {
            return "esta enseñando...";
        }
    }
}
