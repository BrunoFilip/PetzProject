using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Petz.Models
{
    public class Oglas
    {
        public int Id { get; set; }
        public float Cijena { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
    }
}