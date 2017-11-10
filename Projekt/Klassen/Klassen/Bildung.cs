using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public abstract class Bildung : Raum
    {
        //public Wohnung(double flaeche, double brandgefahr, String bezeichnung) : base(flaeche, brandgefahr, bezeichnung) { }

        private String typRaum = "Bildung";
        //private string bezeichnung;

        public Bildung(double flaeche, double brandgefahr, string bezeichnung)
        {
            Flaeche = flaeche;
            Brandgefahr = brandgefahr;
            Bezeichung = bezeichnung;
            TypRaume = typRaum;
        }


    }
}
