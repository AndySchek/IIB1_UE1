﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public class Bueroarbeit : Raum
    {

        private String typRaum = "Büroarbeit";

        public Bueroarbeit() : base() { TypRaume = typRaum; }
        public Bueroarbeit(Raum raum) : base(raum) { TypRaume = typRaum; }
        public Bueroarbeit(double flaeche, double brandgefahr, String bezeichnung) : base(flaeche, brandgefahr, bezeichnung) { TypRaume = typRaum; }

        /*
        public Bueroarbeit(double flaeche, double brandgefahr, string bezeichnung)
        {
            Flaeche = flaeche;
            Brandgefahr = brandgefahr;
            Bezeichung = bezeichnung;
            TypRaume = typRaum;
        }
        */


    }
}