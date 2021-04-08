using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRAZOR.Models
{
    public class Biblioteca
    {
        public List<Libro> Libros { get; set; }
        public Biblioteca() 
        { 
            Libros = new List<Libro>
            { 
                new Libro{ Isbn = "11122",Titulo = "LosPiratasdelCaribe",TipoLibro = "Novela"},
                new Libro{ Isbn = "22211",Titulo = "LosPilaresdelatierra",TipoLibro = "Novela"},
                new Libro{ Isbn = "33311",Titulo = "SteveJobs",TipoLibro = "Biografía"} 
            }; 
        }
        public Libro ObtenerPorIsbn(string isbn)
        {
            foreach(var libroBuscar in Libros) 
            {
                if (libroBuscar.Isbn==isbn)
                {
                    return libroBuscar;
                }
            }
            return null;
        }
        
    }
}