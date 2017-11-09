using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Raum
    {
        //Attribute der Klasse
        protected double raumflaeche;
        protected double brandgefahr;
        protected String bezeichung;
        protected Feuerloecher feuerloecher;

        //Properties der Klasse
        public double Flaeche { get { return raumflaeche; } set { raumflaeche = value; } }
        public double Brandgefahr { get { return brandgefahr; } set { brandgefahr = value; } }
        public String Bezeichung { get { return bezeichung; } set { bezeichung = value; } }



        //Standard Konstruktor
        public Raum()
        {
            raumflaeche = 0;
            brandgefahr = 0;
            bezeichung = "";
        }

        //Allgemeiner Konstruktor1
        public Raum(Raum _raum)
        {
            this.raumflaeche = _raum.Flaeche;
            this.brandgefahr = _raum.Brandgefahr;
            this.bezeichung = _raum.Bezeichung;
        }

        //Allgemeiner Konstruktor2
        public Raum(double _flaeche, double _brandgefahr, String _bezeichnung)
        {
            this.raumflaeche = _flaeche;
            this.brandgefahr = _brandgefahr;
            this.bezeichung = _bezeichnung;
        }

    }
}
