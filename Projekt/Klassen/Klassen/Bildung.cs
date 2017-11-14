﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public class Bildung : Raum
    {

        private String typRaum = "Bildung";

        public Bildung() : base() { TypRaume = typRaum; }
        public Bildung(Raum raum) : base(raum) { TypRaume = typRaum; }
        public Bildung(double flaeche, double brandgefahr, String bezeichnung, Feuerloecher feuerloecher) : base(flaeche, brandgefahr, bezeichnung, feuerloecher) { TypRaume = typRaum; }

    }
}
