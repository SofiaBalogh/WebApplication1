using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models; //saját projectem neve, így tudja h hol az osztály!

namespace WebApplication1.Controllers
{
    public class FilmekController : Controller
    {
        // GET: Filmek/Random
        public ActionResult Random()
        {
            var film = new Film() {Cim="Nincs ilyen film" };
            return View(film);
        }
    }
}