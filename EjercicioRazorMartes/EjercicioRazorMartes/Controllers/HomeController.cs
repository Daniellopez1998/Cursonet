using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioRazorMartes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PracticaEdad()
        {
            return View();
        }

        //Mismo metodo pero con operativas de negocio o lógico
        [HttpPost]
        public ActionResult PracticaEdad(int txtan)
        {
            int edad = 2021 - txtan;
            ViewBag.e = edad;
            return View();
        }

        public ActionResult Calculadora()
        {
            return View();
        }

       [HttpPost]
       public ActionResult Calculadora(double txt1, double txt2)
        {
            ViewBag.num1 = txt1;
            ViewBag.num2 = txt2;
            ViewBag.s = txt1 + txt2;
            ViewBag.r = txt1 - txt2;
            ViewBag.p = txt1 * txt2;
            ViewBag.d = txt1 / txt2;
            return View();
        }

        public ActionResult Coversor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Coversor(double txtc, double txtp)
        {
            ViewBag.c = txtc;
            ViewBag.f = (txtc * 9 / 5) + 32;
            ViewBag.p = txtp;
            ViewBag.m = txtp * 0.0254;
            return View();
        }

        public ActionResult Descuento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Descuento(double txttpr, double txttpa)
        {
            double x;
            ViewBag.tpr = txttpr;
            ViewBag.tpa = txttpa;
            x = txttpr - txttpa;
            ViewBag.pd = x * 100 / txttpr;
            return View();
        }

        public ActionResult Clase()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Clase(int txtsus, int txtapr, int txtnot, int txtsob)
        {
            ViewBag.sus = txtsus;
            ViewBag.apr = txtapr;
            ViewBag.not = txtnot;
            ViewBag.sob = txtsob;
            int x = txtsus + txtsob + txtnot + txtapr;
            ViewBag.psup = (txtsob + txtnot + txtapr) * 100 / x;
            ViewBag.psus = txtsus * 100 / x;
            ViewBag.papr = txtapr * 100 / x;
            ViewBag.pnot = txtnot * 100 / x;
            ViewBag.psob = txtsob * 100 / x;
            return View();
        }
    }
}