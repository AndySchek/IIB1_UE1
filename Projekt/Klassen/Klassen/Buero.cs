using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Buero : Raum
    {
        //public String typRaum = "Büro";

        public Buero() : base() { TypRaume = typRaum; }
        public Buero(Raum raum) : base(raum) { TypRaume = typRaum; }
        public Buero(double flaeche, String bezeichnung, BindingList<Feuerloescher> feuerloescher, BindingList<Material> materialien) : base(flaeche, bezeichnung, feuerloescher, materialien) { TypRaume = typRaum; }
    }
}
