using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciasmartes
{
    class Nomina
    {
        private int diasLaborados;
        public int DiasLaborados { get; set; }
        
        //METODO PARA CALCULAR LA NOMINA
        public decimal Calcularnomina (int diasLab, decimal valoDia)
        {
            decimal totalSalario = diasLab * valoDia;
            return totalSalario;
        }
    }
}
