﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public class Buero : Raum
    {

        public Buero() : base() {  }
        public Buero(Raum r) : base(r) { }
        public Buero(double flaeche, double brandgefahr, String bezeichnung, String typeRaum) : base(flaeche, brandgefahr, bezeichnung, typeRaum) {  }

    }
}
