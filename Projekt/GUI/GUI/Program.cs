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
        }
   

        private static void createRaume(List<String> typRaumList)
        {
            Random rd = new Random();
            for (int i = 0; i < 4; i++)
            {
                double bueroFlaeche = rd.NextDouble() * rd.Next(50, 100);
                double seminarraumFlaeche = rd.NextDouble() * rd.Next(50, 100);
                double flurFlaeche = rd.NextDouble() * rd.Next(50, 100);
                double sanitaerraumFlaeche = rd.NextDouble() * rd.Next(50, 100);

                String bueroNummer = rd.Next(1, 75).ToString() + "a [Büro]";
                String seminarraumNummer = rd.Next(1, 75).ToString() + "b [Seminarraum]";
                String flurNummer = rd.Next(1, 75).ToString() + "c [Flur]";
                String sanitaerraumNummer = rd.Next(1, 75).ToString() + "d [Sanitärraum]";


                String bueroTypRaumName = typRaumlist[rd.Next(0, 5)];
                String seminarraumTypRaumName = typRaumlist[rd.Next(0, 5)];
                String flurTypRaumName = typRaumlist[rd.Next(0, 5)];
                String sanitaerraumTypRaumName = typRaumlist[rd.Next(0, 5)];

                Buero buero = new Buero(bueroFlaeche, 10.0, bueroNummer, bueroTypRaumName);
                Seminarraum seminarraum = new Seminarraum(seminarraumFlaeche, 10.0, seminarraumNummer, seminarraumTypRaumName);
                Flur flur = new Flur(flurFlaeche, 10.0, flurNummer, flurTypRaumName);
                Sanitaerraum sanitaerraum = new Sanitaerraum(sanitaerraumFlaeche, 10.0, sanitaerraumNummer, sanitaerraumTypRaumName);

                raeume.Add(buero);
                raeume.Add(seminarraum);
                raeume.Add(flur);
                raeume.Add(sanitaerraum);
            }
        }


    }
}
