using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperasWebSite.Data;
using OperasWebSite.Models;

namespace OperasWebSite.Controllers
{
    public class OperaController : Controller
    {
        //crear una instancia del Context
        private OperaDBContext context = new OperaDBContext();
        // GET: Opera
        public ActionResult Index()
        {
            List<Opera> lista = context.Operas.ToList();

            return View("Index", lista);
        }
        //GET: /Opera/Create
        [HttpGet]
        public ActionResult Create()
        {
            Opera opera = new Opera();

            return View("Crear", opera);
        }

        //POST: /Opera/Create
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Crear", opera);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Opera opera = context.Operas.Find(id);

            if (opera == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(opera);
            }

        }
        
        // GET: /Opera/Delete/id 
        [HttpGet]
        public ActionResult Delete(int id)
        {

            Opera opera = context.Operas.Find(id);

            if (opera == null)
            {
                return HttpNotFound();

            }

            return View("Delete", opera);

        }



        [HttpPost]
        [ActionName("Delete")]

        //POST: /opera/Delete

        public ActionResult DeleteConfirmed (int id) 
        {
            Opera opera = context.Operas.Find(id);

            if (opera != null)
            {
                context.Operas.Remove(opera);
                context.SaveChanges();  
            }
            return RedirectToAction("Index");
        }
    }
}