using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public class Wohnung : Raum
    {

        public String typRaum = "Wohnung";

        public Wohnung() : base() { TypRaume = typRaum; }
        public Wohnung(Raum raum) : base(raum) { TypRaume = typRaum; }
        public Wohnung(double flaeche, double brandgefahr, String bezeichnung) : base(flaeche, brandgefahr, bezeichnung) { TypRaume = typRaum; }


    }
}
