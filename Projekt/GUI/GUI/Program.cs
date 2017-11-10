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
        private static List<String> typRaumlist = new List<String>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            createTypRaume();
            createRaume(typRaumlist);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(raeume, typRaumlist));
        }

        private static void createTypRaume()
        {
            typRaumlist.Add("Wohnung");
            typRaumlist.Add("Büroarbeit");
            typRaumlist.Add("Bildung");
            typRaumlist.Add("Forschung");
            typRaumlist.Add("Verkaufen");
            typRaumlist.Add("Schlafzimmer");
            typRaumlist.Add("Küche");
            typRaumlist.Add("Sportraum");
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


                String bueroTypRaumName = typRaumlist[rd.Next(0, 8)];
                String seminarraumTypRaumName = typRaumlist[rd.Next(0, 8)];
                String flurTypRaumName = typRaumlist[rd.Next(0, 8)];
                String sanitaerraumTypRaumName = typRaumlist[rd.Next(0, 8)];
                String schlafzimmerTypRaumName = typRaumlist[rd.Next(0, 8)];
                String kuecheTypRaumName = typRaumlist[rd.Next(0, 8)];
                String sportraumTypRaumName = typRaumlist[rd.Next(0, 8)];

                Buero buero = new Buero(bueroFlaeche, 10.0, bueroNummer, bueroTypRaumName);
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
            }
        }


    }
}
