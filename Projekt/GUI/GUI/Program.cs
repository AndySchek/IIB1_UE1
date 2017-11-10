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

        private static BindingList<Wohnung> wohnungRaeme = new BindingList<Wohnung>();
        private static BindingList<Bueroarbeit> bueroRaeme = new BindingList<Bueroarbeit>();
        private static BindingList<Bildung> bildungRaeme = new BindingList<Bildung>();

        private static List<String> typRaumlist = new List<String>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            createWohnungRaume();
            createBueroRaume();
            createBildungRaume();
            addRaume();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(raeume));
        }


        private static void createWohnungRaume()
        {
            Random rd = new Random();
            double kuecheFlaeche = rd.NextDouble() * rd.Next(5, 10);
            double schlafraumFlaeche = rd.NextDouble() * rd.Next(10, 20);
            double speiseraumFlaeche = rd.NextDouble() * rd.Next(10, 20);
            double wohnraumFlaeche = rd.NextDouble() * rd.Next(10, 20);

            Kueche kueche = new Kueche(kuecheFlaeche, 10, "Küche");
            Schlafraum schlafraum = new Schlafraum(schlafraumFlaeche, 10, "Schlafraum");
            Speiseraum speiseraum = new Speiseraum(speiseraumFlaeche, 10, "Speiseraum");
            Wohnraum wohnraum = new Wohnraum(wohnraumFlaeche, 10, "Wohnraum");

            wohnungRaeme.Add(kueche);
            wohnungRaeme.Add(schlafraum);
            wohnungRaeme.Add(speiseraum);
            wohnungRaeme.Add(wohnraum);

        }

        private static void createBueroRaume()
        {
            Random rd = new Random();
            double bueroFlaeche = rd.NextDouble() * rd.Next(50, 100);
            double grossraumbueroFlaeche = rd.NextDouble() * rd.Next(50, 150);
            double besprechungsraumFlaeche = rd.NextDouble() * rd.Next(10, 20);
            double konstruktionsraumFlaeche = rd.NextDouble() * rd.Next(20, 500);
            double zeichenraumFlaeche = rd.NextDouble() * rd.Next(10, 30);
            double buerogeraeteraumFlaeche = rd.NextDouble() * rd.Next(10, 50);

            Buero buero = new Buero(bueroFlaeche, 10, "Büroraum");
            Grossraumbuero grossraumbuero = new Grossraumbuero(grossraumbueroFlaeche, 10, "Großraumbüro");
            Besprechungsraum besprechungsraum = new Besprechungsraum(besprechungsraumFlaeche, 10, "Besprechungsraum");
            Konstruktionsraum konstruktionsraum = new Konstruktionsraum(konstruktionsraumFlaeche, 10, "Konstruktionsraum");
            Zeichenraum zeichenraum = new Zeichenraum(zeichenraumFlaeche, 10, "Zeichenraum");
            Buerogeraeteraum buerogeraeteraum = new Buerogeraeteraum(buerogeraeteraumFlaeche, 10, "Bürogeräteräume");

            bueroRaeme.Add(buero);
            bueroRaeme.Add(grossraumbuero);
            bueroRaeme.Add(besprechungsraum);
            bueroRaeme.Add(konstruktionsraum);
            bueroRaeme.Add(zeichenraum);
            bueroRaeme.Add(buerogeraeteraum);
        }

        private static void createBildungRaume()
        {
            Random rd = new Random();
            double seminarraumFlaeche = rd.NextDouble() * rd.Next(30, 100);
            double flurFlaeche = rd.NextDouble() * rd.Next(10, 50);
            double sanitaerraumFlaeche = rd.NextDouble() * rd.Next(10, 70);
            double sportraumFlaeche = rd.NextDouble() * rd.Next(50, 200);
            double unterrichtsraumFlaeche = rd.NextDouble() * rd.Next(20, 100);
            double uebungsraumFlaeche = rd.NextDouble() * rd.Next(20, 100);
            double hoersaalFlaeche = rd.NextDouble() * rd.Next(100, 200);
            double bibliotheksraumFlaeche = rd.NextDouble() * rd.Next(50, 200);

            Seminarraum seminarraum = new Seminarraum(seminarraumFlaeche, 10, "Seminarraum");
            Flur flur = new Flur(flurFlaeche, 10, "Flur");
            Sanitaerraum sanitaerraum = new Sanitaerraum(sanitaerraumFlaeche, 10, "Sanitärraum");
            Sportraum sportraum = new Sportraum(sportraumFlaeche, 10, "Sportraum");
            Unterrichtsraum unterrichtsraum = new Unterrichtsraum(unterrichtsraumFlaeche, 10, "Unterrichtsraum");
            Uebungsraum uebungsraum = new Uebungsraum(uebungsraumFlaeche, 10, "Übungsraum");
            Hoersaal hoersaal = new Hoersaal(hoersaalFlaeche, 10, "Hörsaal");
            Bibliotheksraum bibliotheksraum = new Bibliotheksraum(bibliotheksraumFlaeche, 10, "Bibliotheksraum");


            bildungRaeme.Add(seminarraum);
            bildungRaeme.Add(flur);
            bildungRaeme.Add(sanitaerraum);
            bildungRaeme.Add(sportraum);
            bildungRaeme.Add(unterrichtsraum);
            bildungRaeme.Add(uebungsraum);
            bildungRaeme.Add(hoersaal);
            bildungRaeme.Add(bibliotheksraum);

        }



        private static void addRaume()
        {
            foreach(Raum r in wohnungRaeme)
            {
                raeume.Add(r);
            }

            foreach (Raum r in bueroRaeme)
            {
                raeume.Add(r);
            }


            foreach (Raum r in bildungRaeme)
            {
                raeume.Add(r);
            }

        }


            private static void createRaume(List<String> typRaumList)
        {
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                double bueroFlaeche = rd.NextDouble() * rd.Next(50, 100);
                double seminarraumFlaeche = rd.NextDouble() * rd.Next(70, 150);
                double flurFlaeche = rd.NextDouble() * rd.Next(10, 50);
                double sanitaerraumFlaeche = rd.NextDouble() * rd.Next(10, 70);
                double schlafzimmerFlaeche = rd.NextDouble() * rd.Next(10, 20);
                double kuecheFlaeche = rd.NextDouble() * rd.Next(10, 20);
                double sportraumFlaeche = rd.NextDouble() * rd.Next(50, 200);

                String bueroNummer = rd.Next(1, 75).ToString() + "a [Büro]";
                String seminarraumNummer = rd.Next(1, 75).ToString() + "b [Seminarraum]";
                String flurNummer = rd.Next(1, 75).ToString() + "c [Flur]";
                String sanitaerraumNummer = rd.Next(1, 75).ToString() + "d [Sanitärraum]";
                String schlafzimmerNummer = rd.Next(1, 75).ToString() + "f [Schlafzimmer]";
                String kuecheNummer = rd.Next(1, 75).ToString() + "f [Küche]";
                String sportraumNummer = rd.Next(1, 75).ToString() + "g [Sportraum]";


                String bueroTypRaumName = typRaumlist[rd.Next(0, 5)];
                String seminarraumTypRaumName = typRaumlist[rd.Next(0, 5)];
                String flurTypRaumName = typRaumlist[rd.Next(0, 5)];
                String sanitaerraumTypRaumName = typRaumlist[rd.Next(0, 5)];
                String schlafzimmerTypRaumName = typRaumlist[rd.Next(0, 5)];
                String kuecheTypRaumName = typRaumlist[rd.Next(0, 5)];
                String sportraumTypRaumName = typRaumlist[rd.Next(0, 5)];

                /*Buero buero = new Buero(bueroFlaeche, 10.0, bueroNummer, bueroTypRaumName);
                Seminarraum seminarraum = new Seminarraum(seminarraumFlaeche, 10.0, seminarraumNummer, seminarraumTypRaumName);
                Flur flur = new Flur(flurFlaeche, 10.0, flurNummer, flurTypRaumName);
                Sanitaerraum sanitaerraum = new Sanitaerraum(sanitaerraumFlaeche, 10.0, sanitaerraumNummer, sanitaerraumTypRaumName);
                Schlafzimmer schlafzimmer = new Schlafzimmer(schlafzimmerFlaeche, 10.0, schlafzimmerNummer, schlafzimmerTypRaumName);
                Kueche kueche = new Kueche(kuecheFlaeche, 10.0, kuecheNummer, kuecheTypRaumName);
                Sportraum sportraum = new Sportraum(sportraumFlaeche, 10.0, sportraumNummer, sportraumTypRaumName);

                raeume.Add(buero);
                raeume.Add(seminarraum);
                raeume.Add(flur);
                raeume.Add(sanitaerraum);
                raeume.Add(schlafzimmer);
                raeume.Add(kueche);
                raeume.Add(sportraum);
                */
            }
        }


    }
}
