using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        protected String typRaum;
        protected Feuerloecher feuerloescher;
        protected int loeschmitteleinheiten;

        //Properties der Klasse
        public double Flaeche { get { return raumflaeche; } set { raumflaeche = value; } }
        public double Brandgefahr { get { return brandgefahr; } set { brandgefahr = value; } }
        public String Bezeichung { get { return bezeichung; } set { bezeichung = value; } }
        public String TypRaume { get { return typRaum; } set { typRaum = value; } }
        public Feuerloecher Feuerloecher { get { return feuerloescher; } set { feuerloescher = value; } }
        public int Loeschmitteleinheiten { get { return loeschmitteleinheiten; } set { loeschmitteleinheiten = value; } }



        //Standard Konstruktor
        public Raum()
        {
            raumflaeche = 0;
            brandgefahr = 0;
            bezeichung = "";
            typRaum = "";
            feuerloescher = new Feuerloecher();
            loeschmitteleinheiten = 0;
        }

        //Allgemeiner Konstruktor1
        public Raum(Raum _raum)
        {
            this.raumflaeche = _raum.Flaeche;
            this.brandgefahr = _raum.Brandgefahr;
            this.bezeichung = _raum.Bezeichung;
            this.typRaum = _raum.TypRaume;
            this.feuerloescher = _raum.Feuerloecher;
            this.loeschmitteleinheiten = _raum.loeschmitteleinheiten;
        }

        //Allgemeiner Konstruktor2
        public Raum(double _flaeche, double _brandgefahr, String _bezeichnung, String _typRaum)
        {
            this.raumflaeche = _flaeche;
            this.brandgefahr = _brandgefahr;
            this.bezeichung = _bezeichnung;
            this.typRaum = _typRaum;
            this.loeschmitteleinheiten = countLoeschmitteleinheiten(_flaeche);
            //this.feuerloescherListe = _feuerloecherListe;
        }

        public Raum(double _flaeche, double _brandgefahr, string _bezeichnung, Feuerloecher _feuerloecher)
        {
            this.raumflaeche = _flaeche;
            this.brandgefahr = _brandgefahr;
            this.bezeichung = _bezeichnung;
            this.loeschmitteleinheiten = countLoeschmitteleinheiten(_flaeche);
            this.feuerloescher = _feuerloecher;
        }

        public int countLoeschmitteleinheiten(double raumFlaeshe)
        {

            int LE = 6;
            if (raumFlaeshe <= 50) return LE;
            LE += 3;
            if (raumFlaeshe > 50 && raumFlaeshe <= 100) return LE;
            LE += 3;
            for (int k = 200; k <= 1000; k += 100, LE += 3)
            {
                if (raumFlaeshe <= k) return LE;
            }
            LE += 3;
            for (int k = 1250; ; k += 250, LE += 6)
            {

                if (raumFlaeshe <= k) return LE;
            }
        }
    }
}
