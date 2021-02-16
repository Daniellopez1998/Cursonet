using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public abstract class Perro
    {
        //Clase principal
        public virtual string Ladrar()
        {
                return "Guau!!!";
        }
        public abstract string Dormir();
            //Variables
            public decimal altura;
            public decimal peso;
            public string color;
            //Procedimiento de propiedad
            //Declarar el procedimiento property
            public decimal PAltura
            {
                get
                {
                    return altura;
                }
                set
                {
                    altura = value;
                }
            }

            public decimal PPeso
            {
                get
                {
                    return peso;
                }
            }

            public string PColor
            {
                get
                {
                    return color;
                }
                set
                {
                    color = value;
                }
            }
        
    }
    public class Chihuahua : Perro
    {

        public override string Ladrar()
        {
                return "Guau!!!";
        }
        public override string Dormir()
        {
            return "Chihuahua durmiendo";
        }
    }   

    public class Bulldog : Perro
    {
        public override string Ladrar()
        {
                return "Guau!!!";
        }
        public override string Dormir()
        {
            return "Bulldog durmiendo";
        }
    }
}
