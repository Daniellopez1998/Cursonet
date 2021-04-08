using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EmpleadoDbContext objConext = new EmpleadoDbContext())
            {
                Console.WriteLine("¿Quieres añadir un usuario a la base de datos? (EsCribe si o no)");
                string i;
                i = Console.ReadLine();
                while (i == "si" || i == "Si" || i == "SI") { 
                Empleado objEmpleado = new Empleado();
                Console.WriteLine("Mete el nombre");
                objEmpleado.EmpName = Console.ReadLine();
                Console.WriteLine("Mete la dirección");
                objEmpleado.Address = Console.ReadLine();
                Console.WriteLine("Introduce un email");
                objEmpleado.EmailId = Console.ReadLine();
                Console.WriteLine("Mete el  Móvil");
                objEmpleado.MobileNo = Console.ReadLine();
                Console.WriteLine("Mete nombre dedepartamento");
                objEmpleado.DeptName = Console.ReadLine();
                objConext.Empleados.Add(objEmpleado);
                objConext.SaveChanges();
                var empDetails = objConext.Empleados;
                Console.WriteLine("Name" + "" + "Address" + "" + "EmailId" + "" + "MobileNumber" + "" + "DeptName");
                Console.WriteLine("----");
                foreach (var item in empDetails)
                {
                    Console.WriteLine(item.EmpName + "|" + item.Address + "|" + item.MobileNo + "|" + item.EmailId + "|" + item.DeptName);
                }
                Console.ReadLine();
                Console.WriteLine("¿Quieres añadir un usuario a la base de datos? (EsCribe si o no)");
                }

            }
        }
    }
}
