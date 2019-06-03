using Petz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petz.Controllers
{
    public class PetzController : Controller
    {
        Baza baza = new Baza();

        // GET: Petz
        public ActionResult Register()
        {
            Korisnik korisnik = new Korisnik();

            return View();
        }

        [HttpPost]
        public ActionResult Register(Korisnik _korisnik)
        {
            if (ModelState.IsValid)
            {
                baza.DodajKorisnika(_korisnik);
            }

            return RedirectToAction("PopisKorisnika");
        }

        public ActionResult PopisKorisnika()
        {
            return View(baza.VratiKorisnike());
        }

        public ActionResult Oglasnik()
        {
            return View(baza.VratiOglase());
        }

        public ActionResult CreateOglas()
        {
            Oglas oglas = new Oglas();

            return View(oglas);
        }

        [HttpPost]
        public ActionResult CreateOglas(Oglas _oglas)
        {
            if(ModelState.IsValid)
            {
                baza.DodajOglas(_oglas);
            }

            return RedirectToAction("Oglasnik");
        }
    }
}