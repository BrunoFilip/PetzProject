using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Petz.Models
{
    public class Baza
    {
        private static List<Korisnik> korisnici = new List<Korisnik>();
        private static List<Oglas> oglasi = new List<Oglas>();

        private static bool IsEmpty = true;

        public Baza()
        {
            if(IsEmpty)
            {
                IsEmpty = false;

                oglasi.Add(new Oglas { Naslov = "Bijeli pas", Opis = "Pas je bijele boje sa crnim točkama, vrlo zaigran.", Cijena = 550f });
                oglasi.Add(new Oglas { Naslov = "Crni pas", Opis = "Pas je crne boje sa bijelim točkama, vrlo zaigran.", Cijena = 650f });
                oglasi.Add(new Oglas { Naslov = "Žuti pas", Opis = "Pas je zute boje sa crnim točkama, vrlo zaigran.", Cijena = 750f });
                oglasi.Add(new Oglas { Naslov = "Smeđi pas", Opis = "Pas je smeđe boje sa crnim točkama, vrlo zaigran.", Cijena = 850f });
            }
        }

        public void DodajOglas(Oglas _oglas)
        {
            if(oglasi.Count == 0)
            {
                _oglas.Id = 0;
            }
            else
            {
                int id = oglasi.Max(x => x.Id) + 1;
                _oglas.Id = id;
            }

            oglasi.Add(_oglas);
        }

        public void DodajKorisnika(Korisnik _korisnik)
        {
            if (korisnici.Count == 0)
            {
                _korisnik.Id = 0;
            }
            else
            {
                int id = korisnici.Max(x => x.Id) + 1;
                _korisnik.Id = id;
            }

            korisnici.Add(_korisnik);
        }

        public List<Oglas> VratiOglase()
        {
            return oglasi;
        }

        public List<Korisnik> VratiKorisnike()
        {
            return korisnici;
        }
    }
}