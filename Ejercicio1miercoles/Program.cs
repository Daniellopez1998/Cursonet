using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1miercoles
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Creo el objeto estudiante y meto datos
            Estudiante Est1 = new Estudiante();
            
            Est1.SetNombre("Eustaquia");
            Est1.SetApellidos("Jimenez Gonzalez");
            Est1.SetEdad(23);
            Est1.Saludar();
            Est1.Estudiar();

            Profesor Pro1 = new Profesor();
            Pro1.SetNombre("Ematildo");
            Pro1.SetApellidos("Rodriguez Cano");
            Pro1.SetEdad(54);
            Pro1.Saludar();
            Pro1.Explicar();
           
            Console.ReadLine();
        }
    }
}
