using System;
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
        public Bildung(double flaeche, double brandgefahr, String bezeichnung) : base(flaeche, brandgefahr, bezeichnung) { TypRaume = typRaum; }
        /*public Bildung(double flaeche, double brandgefahr, string bezeichnung)
        {
            Flaeche = flaeche;
            Brandgefahr = brandgefahr;
            Bezeichung = bezeichnung;
            TypRaume = typRaum;
        }
        */

    }
}
