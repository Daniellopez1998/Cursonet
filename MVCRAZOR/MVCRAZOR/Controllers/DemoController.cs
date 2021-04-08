using MVCRAZOR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRAZOR.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //Controlador generado para la vista Demo
        public ActionResult Index()
        {
            //La primera parte, solo un mensae utilizacion del ViewBag
            //ViewBag.Mensaje = "Acceso a la vista Demo";
            //return View();


            //Segunda parte con la clase libro
            //var libro = new Libro{Isbn = "1122",Titulo = "El pricipito",TipoLibro = "Novela"};
            //return View(libro);


            //Tercera parte con una lista de libros
            var libros = new List<Libro>
            {
                new Libro {Isbn = "1122",Titulo = "El pricipito",TipoLibro = "Novela"},new Libro{Isbn = "1123",Titulo = "El sapo toli",TipoLibro = "Novela"},
                new Libro {Isbn = "1124",Titulo = "101 dalmatas",TipoLibro = "Novela"}
            };
            return View(libros);
        }
    }
}