using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public abstract class Wohnung : Raum
    {

        private String typRaum = "Wohnung";

        public Wohnung(double flaeche, double brandgefahr, string bezeichnung)
        {
            Flaeche = flaeche;
            Brandgefahr = brandgefahr;
            Bezeichung = bezeichnung;
            TypRaume = typRaum;
        }


    }
}
