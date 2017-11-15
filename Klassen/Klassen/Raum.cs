﻿using System;
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
<<<<<<< HEAD
        protected double grundflaeche;
=======
        protected double grundflaeche;
>>>>>>> ac2e925c57dca098fc7c682bbb2992d8ff3edf84
        protected String bezeichung;
        protected int loeschmitteleinheiten;
        protected double brandlast;
        protected BindingList<Material> materialien;
        protected BindingList<Feuerloescher> feuerloescherList;
        protected String typRaum;
        //protected double brandgefahr;

        //Properties der Klasse
<<<<<<< HEAD
        public double Grundflaeche { get { return grundflaeche; } set { grundflaeche = value; } }
=======
        public double Grundflaeche { get { return grundflaeche; } set { grundflaeche = value; } }
>>>>>>> ac2e925c57dca098fc7c682bbb2992d8ff3edf84
        public String Bezeichung { get { return bezeichung; } set { bezeichung = value;  } }
        public int Loeschmitteleinheiten { get { return loeschmitteleinheiten; } set { loeschmitteleinheiten = value; } }
        public double Brandlast { get { return brandlast; } set { brandlast = value; } } 
        public BindingList<Material> Materialien {  get { return materialien; } set { materialien = value; } }
        public BindingList<Feuerloescher > FeuerloecherList { get { return feuerloescherList; } set { feuerloescherList = value; } }
        public String TypRaume { get { return typRaum; } set { typRaum = value; } }

        //Standard Konstruktor
        public Raum()
        {
            grundflaeche = 0;
            //brandgefahr = 0;
            bezeichung = "";
            typRaum = "";
            materialien = new BindingList<Material>();
            feuerloescherList = new BindingList<Feuerloescher>();
            loeschmitteleinheiten = 0;
        }

        //Allgemeiner Konstruktor1
        public Raum(Raum _raum)
        {
            this.bezeichung = _raum.Bezeichung;
            this.grundflaeche = _raum.Grundflaeche;
            //this.brandgefahr = _raum.Brandgefahr;
            this.typRaum = _raum.TypRaume;
            this.brandlast = _raum.Brandlast;
            this.feuerloescherList = _raum.FeuerloecherList;
            this.loeschmitteleinheiten = _raum.loeschmitteleinheiten;
            this.materialien = _raum.materialien;
        }

        //Allgemeiner Konstruktor2
        public Raum(double _grundflaeche, String _bezeichnung, BindingList<Feuerloescher> _feuerloecher, BindingList<Material> _materialien)
        {
            this.bezeichung = _bezeichnung;
            this.grundflaeche = _grundflaeche;
            this.loeschmitteleinheiten = countLoeschmitteleinheiten(_grundflaeche);
            this.feuerloescherList = _feuerloecher;
            this.materialien = _materialien;

        }

        public int countLoeschmitteleinheiten(double raumflaeche)
        {

            int LE = 6;
            if (raumflaeche <= 50) return LE;
            LE += 3;
            if (raumflaeche > 50 && raumflaeche <= 100) return LE;
            LE += 3;
            for (int k = 200; k <= 1000; k += 100, LE += 3)
            {
                if (raumflaeche <= k) return LE;
            }
            LE += 3;
            for (int k = 1250; ; k += 250, LE += 6)
            {

                if (raumflaeche <= k) return LE;
            }
        }
    }
}