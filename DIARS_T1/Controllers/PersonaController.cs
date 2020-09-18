using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIARS_T1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DIARS_T1.Controllers
{
    public class PersonaController : Controller
    {

      public BDContext _context = new BDContext();

        public IActionResult Index()
        {
            ViewBag.Ciudad = _context.Ciudad.ToList();

            return View(_context.Persona.ToList());
        }


        [HttpGet]
        public ActionResult Create() {

            ViewBag.Ciudad = _context.Ciudad.ToList();

            return View();
        }


        [HttpPost]
        public ActionResult Create(Persona persona)
        {

            _context.Add(persona);
            _context.SaveChanges();

            return RedirectToAction("Index", "Persona");
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Ciudades = _context.Ciudad.ToList();

                ViewBag.BuscarPersona = _context.Persona.Where(o => o.IdPersona == id).FirstOrDefault();

                ViewBag.Persona = _context.Persona.ToList();
                          
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Persona");
            }

        }


        [HttpPost]
        public ActionResult Edit(Persona persona)
        {

            _context.Persona.Update(persona);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {

            var persona = _context.Persona.Where(o => o.IdPersona == id).FirstOrDefault();

            _context.Persona.Remove(persona);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
