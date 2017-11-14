using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    [Serializable]
    public class Feuerloecher
    {
        private String bezeichnung;
        private int loescheinheit;
        private double preis;
        //private double loeschmittelkapazitaet;
        //List<Loeschvermoegen> loeschvermoegenList = new List<Loeschvermoegen>();


        public String Bezeichnung { get { return bezeichnung; } set { bezeichnung = value; } }
        public int Loescheinheit { get { return loescheinheit; } set { loescheinheit = value; } }
        public double Preis { get { return preis; } set { preis = value; } }

        //public double Loeschmittelkapazitaet { get { return loeschmittelkapazitaet; } set { loeschmittelkapazitaet = value; } }
        //public List<Loeschvermoegen> LoeschvermoegenList { get { return loeschvermoegenList; } set { } }
        //public Loeschvermoegen Loeschvermoegen { get { return loeschvermoegen; } set { loeschvermoegen = value; } }


        //Standard Konstruktor
        public Feuerloecher()
        {
            bezeichnung = "";
            loescheinheit = 0;
            preis = 0;

            //loeschmittelkapazitaet = 0;
            /*
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "5A/21B", countLoeschmitteleinheiten = 1 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "8A/34B", countLoeschmitteleinheiten = 2 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "55B", countLoeschmitteleinheiten = 3 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "13A/70B", countLoeschmitteleinheiten = 4 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "89B", countLoeschmitteleinheiten = 5 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "21A/113B", countLoeschmitteleinheiten = 6 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "27A/144B", countLoeschmitteleinheiten = 9 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "34A", countLoeschmitteleinheiten = 10 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "43A/183B", countLoeschmitteleinheiten = 12 });
            loeschvermoegenList.Add(new Loeschvermoegen() { nameLoeschvermoegen = "55A/233B", countLoeschmitteleinheiten = 15 });
            */
        }

        //Allgemeiner Konstruktor2
        public Feuerloecher(String _bezeichnung, int _loescheinheit, double _preis)
        {
            this.bezeichnung = _bezeichnung;
            this.loescheinheit = _loescheinheit;
            this.preis = _preis;
        }

        public Feuerloecher(Loeschvermoegen _loeschvermoegen)
        {
           // this.loeschvermoegen = _loeschvermoegen;
        }
    }
}
