using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Sanitaerraum : Raum
    {
        public String typRaum = "Sanitärraum";

        public Sanitaerraum() : base() { TypRaume = typRaum; }
        public Sanitaerraum(Raum raum) : base(raum) { TypRaume = typRaum; }
        public Sanitaerraum(double flaeche, String bezeichnung, BindingList<Feuerloescher> feuerloescher, Material materialien, double heizwert) : base(flaeche, bezeichnung, feuerloescher, materialien, heizwert) { TypRaume = typRaum; }
    }
}
