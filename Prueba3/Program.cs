using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados Dani = new Empleados();
            Empleados Celso = new Empleados();
            Empleados Sergio = new Empleados();
            Empleados Carmen = new Empleados();

            //valores
            Dani.SueldoBruto=900;
            Celso.SueldoBruto = 1000;
            Sergio.SueldoBruto = 1100;
            Carmen.SueldoBruto = 1200;

            Console.WriteLine("El sueldo de cada dani es: " + Dani.ESueldoBruto);
            Console.WriteLine("El sueldo de cada dani es: " + Celso.ESueldoBruto);
            Console.WriteLine("El sueldo de cada dani es: " + Sergio.ESueldoBruto);
            Console.WriteLine("El sueldo de cada dani es: " + Carmen.ESueldoBruto);

        }
    }
}
