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
        private double preis;
        private double loeschmittelkapazitaet;
        List<Loeschvermoegen> loeschvermoegens = new List<Loeschvermoegen>();


        public double Preis { get { return preis; } set { preis = value; } }
        public double Loeschmittelkapazitaet { get { return loeschmittelkapazitaet; } set { loeschmittelkapazitaet = value; } }

        
        //Standard Konstruktor
        public Feuerloecher()
        {
            preis = 0;
            loeschmittelkapazitaet = 0;
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "5A/21B", countLoeschmitteleinheiten = 1 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "8A/34B", countLoeschmitteleinheiten = 2 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "55B", countLoeschmitteleinheiten = 3 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "13A/70B", countLoeschmitteleinheiten = 4 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "89B", countLoeschmitteleinheiten = 5 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "21A/113B", countLoeschmitteleinheiten = 6 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "27A/144B", countLoeschmitteleinheiten = 9 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "34A", countLoeschmitteleinheiten = 10 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "43A/183B", countLoeschmitteleinheiten = 12 });
            loeschvermoegens.Add(new Loeschvermoegen() { nameLoeschvermoegen = "55A/233B", countLoeschmitteleinheiten = 15 });
        }

        //Allgemeiner Konstruktor2
        public Feuerloecher(double _preis, double _loeschmittelkapazitaet)
        {
            this.preis = _preis;
            this.loeschmittelkapazitaet = _loeschmittelkapazitaet;
        }

    }
}
