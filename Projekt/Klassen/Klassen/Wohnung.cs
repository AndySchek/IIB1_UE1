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

        private String typRaum = "Wohnung";

        public Wohnung() : base() { TypRaume = typRaum; }
        public Wohnung(Raum raum) : base(raum) { TypRaume = typRaum; }

        public Wohnung(double flaeche, double brandgefahr, string bezeichnung)
        {
            Flaeche = flaeche;
            Brandgefahr = brandgefahr;
            Bezeichung = bezeichnung;
            TypRaume = typRaum;
        }


    }
}
