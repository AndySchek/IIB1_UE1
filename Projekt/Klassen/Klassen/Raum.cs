using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public abstract class Raum
    {
        //Attribute der Klasse
        protected String bezeichung;
        protected double raumflaeche;
        protected String typRaum;
        protected double brandlast;
        protected BindingList<Feuerloecher> feuerloescherList;
        protected int loeschmitteleinheiten;
        //protected double brandgefahr;

        //Properties der Klasse
        public String Bezeichung { get { return bezeichung; } set { bezeichung = value;  } }
        public double Flaeche { get { return raumflaeche; } set { raumflaeche = value; } }
        public String TypRaume { get { return typRaum; } set { typRaum = value; } }
        public double Brandlast { get { return brandlast; } set { brandlast = value; } }
        public BindingList<Feuerloecher > FeuerloecherList { get { return feuerloescherList; } set { feuerloescherList = value; } }
        public int Loeschmitteleinheiten { get { return loeschmitteleinheiten; } set { loeschmitteleinheiten = value; } }

        //Standard Konstruktor
        public Raum()
        {
            raumflaeche = 0;
            //brandgefahr = 0;
            bezeichung = "";
            typRaum = "";
            feuerloescherList = new BindingList<Feuerloecher>();
            loeschmitteleinheiten = 0;
        }

        //Allgemeiner Konstruktor1
        public Raum(Raum _raum)
        {
            this.bezeichung = _raum.Bezeichung;
            this.raumflaeche = _raum.Flaeche;
            //this.brandgefahr = _raum.Brandgefahr;
            this.typRaum = _raum.TypRaume;
            this.brandlast = _raum.Brandlast;
            this.feuerloescherList = _raum.FeuerloecherList;
            this.loeschmitteleinheiten = _raum.loeschmitteleinheiten;
        }

        //Allgemeiner Konstruktor2
        public Raum(double _flaeche, String _bezeichnung, BindingList<Feuerloecher> _feuerloecher)
        {
            this.bezeichung = _bezeichnung;
            this.raumflaeche = _flaeche;
            this.loeschmitteleinheiten = countLoeschmitteleinheiten(_flaeche);
            this.feuerloescherList = _feuerloecher;

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
