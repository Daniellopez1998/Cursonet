using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class program
    {
        static void Main(string[] args)
        {

            //Metodo inicial
            //Creamos objetos de la clase perro
            //Constructor

            /* ******************************************Deja de funcionar porque perro pasa a ser una clase abstracta****************************************************
            
            Perro fido = new Perro();
            Perro arturo = new Perro();
            Perro lola = new Perro();

            //Valores
            fido.color = "ROJO";
            fido.altura = 5.2m;
            fido.peso = 12;
            arturo.color = "AZUL";
            arturo.altura = 3m;
            arturo.peso = 6;
            lola.color = "MARRON";
            lola.altura = 1m;
            lola.peso = 3;


            //Acciones
            Console.WriteLine("Fido dice " + fido.Ladrar() + " Es de color " + fido.color + ", mide " + fido.altura + " y pesa" + fido.peso);
            Console.WriteLine("Arturo dice " + arturo.Ladrar() + " Es de color " + arturo.color + ", mide " + arturo.altura + " y pesa" + arturo.peso);
            Console.WriteLine("Lola dice " + lola.Ladrar() + " Es de color " + lola.color + ", mide " + lola.altura + " y pesa" + lola.peso);
            */

            Chihuahua _Chihuahua1 = new Chihuahua();
            Chihuahua _Chihuahua2 = new Chihuahua();
            Bulldog _Bulldog1 = new Bulldog();
            Bulldog _Bulldog2 = new Bulldog();

            Perro[] _Perrera = { _Chihuahua1, _Chihuahua2, _Bulldog1, _Bulldog2 };

            foreach (Perro item in _Perrera)
            {
                Console.WriteLine(item.Ladrar());
                Console.WriteLine(item.Dormir());
                //Console.ReadLine(); con este pararias el bucle
            }
            Console.ReadLine();
        }
    }

}
    


