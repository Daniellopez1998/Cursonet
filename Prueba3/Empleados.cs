using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba3
{
    public class Empleados : Empresas
    {
        public float SueldoBruto;
        public float ESueldoBruto
        {
            get
            {
                return SueldoBruto;
            }
            set
            {
                SueldoBruto = value;
            }
        }
    }
}