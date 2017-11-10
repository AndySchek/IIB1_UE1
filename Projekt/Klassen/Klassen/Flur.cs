using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{

    [Serializable]
    public class Flur : Raum
    {
        public Flur(double flaeche, double brandgefahr, String bezeichnung, String typeRaum) : base(flaeche, brandgefahr, bezeichnung, typeRaum) { }

    }
}
