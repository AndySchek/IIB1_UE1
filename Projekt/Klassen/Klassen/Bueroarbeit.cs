using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public abstract class Bueroarbeit : Raum
    {

        private String typRaum = "Büroarbeit";

        public Bueroarbeit(double flaeche, double brandgefahr, string bezeichnung)
        {
            Flaeche = flaeche;
            Brandgefahr = brandgefahr;
            Bezeichung = bezeichnung;
            TypRaume = typRaum;
        }


    }
}
