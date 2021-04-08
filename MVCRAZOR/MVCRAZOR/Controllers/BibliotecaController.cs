using MVCRAZOR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace MVCRAZOR.Controllers
{
    public class BibliotecaController : Controller
    {
        //invocamos a la clase Biblioteca y le ponemos el using del models
        //static no necesita que se instacie la clase biblioteca
        static Biblioteca miBiblioteca = new Biblioteca();

        // GET: Biblioteca: Devuelve una lista de libros en un Formulario tipo Grid
        public ActionResult Index()
        {
            return View(miBiblioteca.Libros.ToList());
        }

        // GET: Biblioteca/Details/5
        public ActionResult Details(int id)
        {
            return View(miBiblioteca.ObtenerPorIsbn(id.ToString()));;
        }

        // GET: Biblioteca/Create---> Va a solicitar los datos del libro
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biblioteca/Create---> Va a crearlos directamente en el metodo post
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                miBiblioteca.Libros.Add(new Libro
                {
                    Isbn = collection["Isbn"],
                    Titulo = collection["Titulo"],
                    TipoLibro = collection["TipoLibro"]
                });
                grabarEnBD(collection["Isbn"], collection ["Titulo"], collection["TipoLibro"]);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public void grabarEnBD(String Isbn, string Titulo, string TipoLibro)
        {
            SqlConnection conexion = new SqlConnection("Data Source=CADAVILES04\\SQLEXPRESS;Initial Catalog=mvcRazor;Integrated Security=True");
            conexion.Open();
            string cadena = "Insert into libro(Isbn,Titulo,TipoLibro)" + "values('" + Isbn + "','" + Titulo + "','" + TipoLibro + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // GET: Biblioteca/Edit/5 pasamos por parametro el Isbn para modificar el libro solicitado
        public ActionResult Edit(int id)
        {
            return View(miBiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // POST: Biblioteca/Edit/5 programamos el proceso de modificar el libro
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                foreach (Libro l in miBiblioteca.Libros)
                {
                    if (l.Isbn == id) 
                    {
                        l.Titulo = collection["Titulo"];
                        l.TipoLibro = collection["TipoLibro"];
                        
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Delete/5 recuperamos la lista de borrado. Le pasamos el id donde el Isbn es el libro a borrar
        public ActionResult Delete(int id)
        {

            return View(miBiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // POST: Biblioteca/Delete/5 Metodo de borrado donde buscamos el isbn del libro
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                foreach (Libro l in miBiblioteca.Libros)
                {
                    if (l.Isbn == id) miBiblioteca.Libros.Remove(l);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
