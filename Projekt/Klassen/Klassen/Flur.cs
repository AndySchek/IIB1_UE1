using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Flur : Raum
    {
        public String typRaum = "Flur";

        public Flur() : base() { TypRaume = typRaum; }
        public Flur(Raum raum) : base(raum) { TypRaume = typRaum; }
        public Flur(double flaeche, String bezeichnung, BindingList<Feuerloescher> feuerloescher, Material materialien, double heizwert) : base(flaeche, bezeichnung, feuerloescher, materialien, heizwert) { TypRaume = typRaum; }
    }
}
