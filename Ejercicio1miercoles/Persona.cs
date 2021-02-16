using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1miercoles
{
    class Persona
    {
        //Atributos solo acceisbles en la misma clase
        protected string nombre;
        protected string apellidos;
        protected int edad;
        
        //Metodos de carga (cargar valores por referencia)
        public void SetNombre(string nome)
        {
            nombre = nome;
        }

        public void SetApellidos(string ape)
        {
            apellidos = ape;
        }
        
        public void SetEdad(int n)
        {
            edad = n;
        }

        public void Saludar()
        {
            Console.WriteLine(this.nombre + " " + this.apellidos + " " + this.edad + "¡Hola!");
        }
    }
}
