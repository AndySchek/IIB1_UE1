using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Seminarraum : Raum
    {
        public String typRaum = "Seminarraum";

        public Seminarraum() : base() { TypRaume = typRaum; }
        public Seminarraum(Raum raum) : base(raum) { TypRaume = typRaum; }
        public Seminarraum(double flaeche, String bezeichnung, BindingList<Feuerloecher> feuerloecher) : base(flaeche, bezeichnung, feuerloecher) { TypRaume = typRaum; }
    }
}
