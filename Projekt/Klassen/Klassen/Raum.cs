using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Raum
    {
        //Attribute der Klasse
        protected double raumflaeche;
        protected double brandgefahr;
        protected String bezeichung;
        protected Feuerloecher feuerloecher;
        protected String typRaum;
        private string bezeichnung;

        //Properties der Klasse
        public double Flaeche { get { return raumflaeche; } set { raumflaeche = value; } }
        public double Brandgefahr { get { return brandgefahr; } set { brandgefahr = value; } }
        public String Bezeichung { get { return bezeichung; } set { bezeichung = value; } }
        public String TypRaume { get { return typRaum; } set { typRaum = value; } }



        //Standard Konstruktor
        public Raum()
        {
            raumflaeche = 0;
            brandgefahr = 0;
            bezeichung = "";
            typRaum = "";
        }

        //Allgemeiner Konstruktor1
        public Raum(Raum _raum)
        {
            this.raumflaeche = _raum.Flaeche;
            this.brandgefahr = _raum.Brandgefahr;
            this.bezeichung = _raum.Bezeichung;
            this.typRaum = _raum.TypRaume;
        }

        //Allgemeiner Konstruktor2
        public Raum(double _flaeche, double _brandgefahr, String _bezeichnung, String _typRaum)
        {
            this.raumflaeche = _flaeche;
            this.brandgefahr = _brandgefahr;
            this.bezeichung = _bezeichnung;
            this.typRaum = _typRaum;
        }

        public Raum(double flaeche, double brandgefahr, string bezeichnung)
        {
            this.raumflaeche = flaeche;
            this.brandgefahr = brandgefahr;
            this.bezeichnung = bezeichnung;
        }
    }
}
