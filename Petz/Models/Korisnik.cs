﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Petz.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
    }
}