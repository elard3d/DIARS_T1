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
    }
}
