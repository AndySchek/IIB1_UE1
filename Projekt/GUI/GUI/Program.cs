using System;
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
        private static BindingList<Feuerloescher> feuerlocherList = new BindingList<Feuerloescher>();
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
            Application.Run(new FormMain(raeume, feuerlocherList));
        }

        private static void createFeuerloecher()
        {
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "5A/21B", Loescheinheit = 1, Preis = 20 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "8A/34B", Loescheinheit = 2, Preis = 40 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "55B", Loescheinheit = 3, Preis = 100 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "13A/70B", Loescheinheit = 4, Preis = 150 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "89B", Loescheinheit = 5, Preis = 200 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "21A/113B", Loescheinheit = 6, Preis = 250 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "27A/144B", Loescheinheit = 9, Preis = 350 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "34A", Loescheinheit = 10, Preis = 400 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "43A / 183B", Loescheinheit = 12, Preis = 500 });
            feuerlocherList.Add(new Feuerloescher() { Bezeichnung = "55A/233B", Loescheinheit = 15, Preis = 700 });

        }

        private static BindingList<Feuerloescher> empfangFeuerlocher(int _anzahl)
        {
            BindingList<Feuerloescher> ffeuerlocherList = new BindingList<Feuerloescher>();
            Feuerloescher feuerloecher;
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

                int bueroFeuerloescherAnzahl = rd.Next(1, 5);
                int flurFeuerloescherAnzahl = rd.Next(1, 5);
                int seminarraumFeuerloescherAnzahl = rd.Next(1, 5);
                int sanitaerraumFeuerloescherAnzahl = rd.Next(1, 5);

                BindingList<Feuerloescher> bueroFeuerlocherListe = empfangFeuerlocher(bueroFeuerloescherAnzahl);
                BindingList<Feuerloescher> flurFeuerlocherListe = empfangFeuerlocher(flurFeuerloescherAnzahl);
                BindingList<Feuerloescher> seminarraumFeuerlocherListe = empfangFeuerlocher(seminarraumFeuerloescherAnzahl);
                BindingList<Feuerloescher> sanitaerraumFeuerlocherListe = empfangFeuerlocher(sanitaerraumFeuerloescherAnzahl);

                BindingList<Material> bueroMaterial = new BindingList<Material>();
                BindingList<Material> flurMaterial = new BindingList<Material>();
                BindingList<Material> seminarraumMaterial = new BindingList<Material>();
                BindingList<Material> sanitaerraumMaterial = new BindingList<Material>();

                Buero buero = new Buero(bueroFlaeche, bezeichnungBueroRaum, bueroFeuerlocherListe, bueroMaterial);
                Flur flur = new Flur(flurFlaeche, bezeichnungFlurRaum, flurFeuerlocherListe, flurMaterial);
                Seminarraum seminarraum = new Seminarraum(seminarraumFlaeche, bezeichnungSeminarRaum, seminarraumFeuerlocherListe, seminarraumMaterial);
                Sanitaerraum sanitaerraum = new Sanitaerraum(satinaerramFlaeche, bezeichnunSanitaerRaum, sanitaerraumFeuerlocherListe, sanitaerraumMaterial);

                raeume.Add(buero);
                raeume.Add(flur);
                raeume.Add(seminarraum);
                raeume.Add(sanitaerraum);

            }

        }

    }
}
