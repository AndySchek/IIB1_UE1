﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Klassen;


namespace GUI
{
    static class Program
    {
        private static BindingList<Raum> raeume = new BindingList<Raum>();
        private static List<Feuerloecher> feuerlocherList = new List<Feuerloecher>();
        static Random rd = new Random();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            createFeuerloecher();
            createRaume();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(raeume));
        }

        private static void createFeuerloecher()
        {
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "5A/21B", Loescheinheit = 1, Preis = 20 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "8A/34B", Loescheinheit = 2, Preis = 40 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "55B", Loescheinheit = 3, Preis = 100 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "13A/70B", Loescheinheit = 4, Preis = 150 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "89B", Loescheinheit = 5, Preis = 200 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "21A/113B", Loescheinheit = 6, Preis = 250 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "27A/144B", Loescheinheit = 9, Preis = 350 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "34A", Loescheinheit = 10, Preis = 400 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "43A / 183B", Loescheinheit = 12, Preis = 500 });
            feuerlocherList.Add(new Feuerloecher() { Bezeichnung = "55A/233B", Loescheinheit = 15, Preis = 700 });

        }

        private static BindingList<Feuerloecher> empfangFeuerlocher(int _anzahl)
        {
            BindingList<Feuerloecher> ffeuerlocherList = new BindingList<Feuerloecher>();
            Feuerloecher feuerloecher;
            for (int i=0; i<_anzahl; i++)
            {
                while (true)
                {
                    feuerloecher = feuerlocherList[rd.Next(1, feuerlocherList.Count)];
                    if (ffeuerlocherList.IndexOf(feuerloecher)==-1) {
                        feuerloecher.Anzahl = 1;
                        ffeuerlocherList.Add(feuerloecher);
                        break;
                    }
                }
            }
            return ffeuerlocherList;
        }

        private static void createRaume()
        {
            
            String name = "Raum ";
            for (int i=0; i<=4; i++)
            {
                double bueroFlaeche = (rd.NextDouble() + 1) * rd.Next(30, 100);
                double flurFlaeche = (rd.NextDouble() + 1) * rd.Next(30, 100);
                double seminarraumFlaeche = (rd.NextDouble() + 1) * rd.Next(50, 100);
                double satinaerramFlaeche = (rd.NextDouble() + 1) * rd.Next(20, 70);

                String bezeichnungBueroRaum = name + rd.Next(1, 75).ToString() + "a";
                String bezeichnungFlurRaum = name + rd.Next(1, 75).ToString() + "b";
                String bezeichnungSeminarRaum = name + rd.Next(1, 75).ToString() + "c";
                String bezeichnunSanitaerRaum = name + rd.Next(1, 75).ToString() + "d";

                int bueroFeuerloecherAnzahl = rd.Next(1, 5);
                int flurFeuerloecherAnzahl = rd.Next(1, 5);
                int seminarraumFeuerloecherAnzahl = rd.Next(1, 5);
                int sanitaerraumFeuerloecherAnzahl = rd.Next(1, 5);

                BindingList<Feuerloecher> bueroFeuerlocherListe = empfangFeuerlocher(bueroFeuerloecherAnzahl);
                BindingList<Feuerloecher> flurFeuerlocherListe = empfangFeuerlocher(flurFeuerloecherAnzahl);
                BindingList<Feuerloecher> seminarraumFeuerlocherListe = empfangFeuerlocher(seminarraumFeuerloecherAnzahl);
                BindingList<Feuerloecher> sanitaerraumFeuerlocherListe = empfangFeuerlocher(sanitaerraumFeuerloecherAnzahl);

                Buero buero = new Buero(bueroFlaeche, bezeichnungBueroRaum, bueroFeuerlocherListe);
                Flur flur = new Flur(flurFlaeche, bezeichnungFlurRaum, flurFeuerlocherListe);
                Seminarraum seminarraum = new Seminarraum(seminarraumFlaeche, bezeichnungSeminarRaum, seminarraumFeuerlocherListe);
                Sanitaerraum sanitaerraum = new Sanitaerraum(satinaerramFlaeche, bezeichnunSanitaerRaum, sanitaerraumFeuerlocherListe);

                raeume.Add(buero);
                raeume.Add(flur);
                raeume.Add(seminarraum);
                raeume.Add(sanitaerraum);

            }

        }

    }
}
