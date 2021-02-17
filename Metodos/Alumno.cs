using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Alumno
    {
        //ATRIBUTOS PRIVADOS: SON ACCESIBLES DESDE AQUI PERO NO DESDE EL PROGRAM
        private string strNombre;
        private int intEdad, dclNota;

        //PROPIEDADES DE LA CLASE ALUMNO
        public int pNota
        {
            get {return dclNota;}
            set {dclNota = value;}
        }
        public int pEdad
        {
            get {return intEdad;}
            set {intEdad = value;}
        }
        public string pNombre
        {
            get {return strNombre;}
            set {strNombre = value;}
        }
    }
    
}
