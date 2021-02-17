using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        /// <summary>
        /// ClASE PRINCIPAL
        /// </summary>
        
        static void Main(string[] args)
        {
            string strCurso = "";
            Alumno a = new Alumno();
            /// <para>
            /// LLAMADA A LOS METODOS
            /// </para>
            pedirDatos(a);
            strCurso = asignarCursos(a);
            mostrarInfo(args, strCurso);
            Console.ReadLine();
        }

        static void pedirDatos(Alumno a)
        {
            Console.Write("Ingrese el nombre: ");
            a.pNombre = Console.ReadLine();
            string linea;
            Console.Write("ingrese la edad: ");
            a.pEdad = int.Parse(linea);
            Console.Write("Ingtrese la nota: ");
            linea = Console.ReadLine();
            a.pNota = int.Parse(linea);
        }

        static string asignarCursos(Alumno a)
        {
            string strCurso = "";
            if (a.pNota >= 40 && a.pNota <= 59)
            {
                strCurso = "B1 LOWER INTERMEDIATE";
            } else if (a.pNota >= 60 && a.pNota < Nota <= 74)
            {
                strCurso = "b2 INTERMEDIATE";
            } else if (a.pNota >= 75 && a.pNota <= 89)
            {
                strCurso = "C! UPPER INTERMEDIATE";
            }else if (a.pNota>=90 && a.pNota <= 100)
            {
                strCurso = "ADVANCED";
            }else if (a.pNota<40 && a.pNota > 100)
            {
                strCurso = "ERROR: VALOR DE LA NOTA FUERA DE RANGO (40-100)";
            }

        }

        static void mostrarInfo(Alumno a, string strCurso)
        {
           
        }
    }
}
