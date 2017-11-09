using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Feuerloecher
    {
        private double preis;
        private double loeschmittelkapazitaet;


        public double Preis { get { return preis; } set { preis = value; } }
        public double Loeschmittelkapazitaet { get { return loeschmittelkapazitaet; } set { loeschmittelkapazitaet = value; } }

        //Standard Konstruktor
        public Feuerloecher()
        {
            preis = 0;
            loeschmittelkapazitaet = 0;
        }

        //Allgemeiner Konstruktor2
        public Feuerloecher(double _preis, double _loeschmittelkapazitaet)
        {
            this.preis = _preis;
            this.loeschmittelkapazitaet = _loeschmittelkapazitaet;
        }
    }
}
