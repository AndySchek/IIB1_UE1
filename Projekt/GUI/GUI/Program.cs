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
        private static List<Loeschvermoegen> loeschvermoegen = new List<Loeschvermoegen>();
        

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
            Application.Run(new FormMain(raeume, loeschvermoegen));
        }

        private static Feuerloecher createFeuerloecher()
        {
            Random rd = new Random((int)DateTime.Now.Ticks);
            Feuerloecher feuerloecher = new Feuerloecher();
            int i = rd.Next(0, 10);
            feuerloecher.Loeschvermoegen = feuerloecher.LoeschvermoegenList[i];
            return feuerloecher;

        }

        private static void createWohnungRaume()
        {
            Random rd = new Random();
            double kuecheFlaeche = (rd.NextDouble() + 1 ) * rd.Next(10, 50);
            double schlafraumFlaeche = (rd.NextDouble() + 1) * rd.Next(20, 50);
            double speiseraumFlaeche = (rd.NextDouble() + 1) * rd.Next(10, 30);
            double wohnraumFlaeche = (rd.NextDouble() + 1) * rd.Next(20, 70);

            Feuerloecher kuechefeuerloecher = createFeuerloecher();
            Feuerloecher schlafraumfeuerloecher = createFeuerloecher();
            Feuerloecher speiseraumfeuerloecher = createFeuerloecher();
            Feuerloecher wohnraumfeuerloecher = createFeuerloecher();

            Wohnung kueche = new Wohnung(kuecheFlaeche, 10, "Küche", kuechefeuerloecher);
            Wohnung schlafraum = new Wohnung(schlafraumFlaeche, 10, "Schlafraum", schlafraumfeuerloecher);
            Wohnung speiseraum = new Wohnung(speiseraumFlaeche, 10, "Speiseraum", speiseraumfeuerloecher);
            Wohnung wohnraum = new Wohnung(wohnraumFlaeche, 10, "Wohnraum", wohnraumfeuerloecher);

            wohnungRaeme.Add(kueche);
            wohnungRaeme.Add(schlafraum);
            wohnungRaeme.Add(speiseraum);
            wohnungRaeme.Add(wohnraum);

        }

        private static void createBueroRaume()
        {
            Random rd = new Random();
            double bueroFlaeche = (rd.NextDouble() + 1) * rd.Next(50, 100);
            double grossraumbueroFlaeche = (rd.NextDouble() + 1) * rd.Next(50, 150);
            double besprechungsraumFlaeche = (rd.NextDouble() + 1) * rd.Next(10, 30);
            double konstruktionsraumFlaeche = (rd.NextDouble() + 1) * rd.Next(20, 500);
            double zeichenraumFlaeche = (rd.NextDouble() + 1) * rd.Next(10, 30);
            double buerogeraeteraumFlaeche = (rd.NextDouble() + 1) * rd.Next(20, 70);


            Feuerloecher buerofeuerloecher = createFeuerloecher();
            Feuerloecher grossraumbuerofeuerloecher = createFeuerloecher();
            Feuerloecher besprechungsraumfeuerloecher = createFeuerloecher();
            Feuerloecher konstruktionsraumfeuerloecher = createFeuerloecher();
            Feuerloecher zeichenraumfeuerloecher = createFeuerloecher();
            Feuerloecher buerogeraeteraumfeuerloecher = createFeuerloecher();

            Bueroarbeit buero = new Bueroarbeit(bueroFlaeche, 10, "Büroraum", buerofeuerloecher);
            Bueroarbeit grossraumbuero = new Bueroarbeit(grossraumbueroFlaeche, 10, "Großraumbüro", grossraumbuerofeuerloecher);
            Bueroarbeit besprechungsraum = new Bueroarbeit(besprechungsraumFlaeche, 10, "Besprechungsraum", besprechungsraumfeuerloecher);
            Bueroarbeit konstruktionsraum = new Bueroarbeit(konstruktionsraumFlaeche, 10, "Konstruktionsraum", konstruktionsraumfeuerloecher);
            Bueroarbeit zeichenraum = new Bueroarbeit(zeichenraumFlaeche, 10, "Zeichenraum", zeichenraumfeuerloecher);
            Bueroarbeit buerogeraeteraum = new Bueroarbeit(buerogeraeteraumFlaeche, 10, "Bürogeräteräume", buerogeraeteraumfeuerloecher);

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
          
            double seminarraumFlaeche = (rd.NextDouble() + 1) * rd.Next(30, 100);
            double flurFlaeche = (rd.NextDouble() + 1) * rd.Next(10, 50);
            double sanitaerraumFlaeche = (rd.NextDouble() + 1) * rd.Next(10, 70);
            double sportraumFlaeche = (rd.NextDouble() + 1) * rd.Next(50, 200);
            double unterrichtsraumFlaeche = (rd.NextDouble() + 1) * rd.Next(20, 100);
            double uebungsraumFlaeche = (rd.NextDouble() + 1) * rd.Next(20, 100);
            double hoersaalFlaeche = (rd.NextDouble() + 1) * rd.Next(100, 200);
            double bibliotheksraumFlaeche = (rd.NextDouble() + 1) * rd.Next(50, 200);

            Feuerloecher seminarraumfeuerloecher = createFeuerloecher();
            Feuerloecher flurfeuerloecher = createFeuerloecher();
            Feuerloecher sanitaerraumfeuerloecher = createFeuerloecher();
            Feuerloecher sportraumfeuerloecher = createFeuerloecher();
            Feuerloecher unterrichtsraumfeuerloecher = createFeuerloecher();
            Feuerloecher uebungsraumfeuerloecher = createFeuerloecher();
            Feuerloecher hoersaalfeuerloecher = createFeuerloecher();
            Feuerloecher bibliotheksraumfeuerloecher = createFeuerloecher();

            Bildung seminarraum = new Bildung(seminarraumFlaeche, 10, "Seminarraum", seminarraumfeuerloecher);
            Bildung flur = new Bildung(flurFlaeche, 10, "Flur", flurfeuerloecher);
            Bildung sanitaerraum = new Bildung(sanitaerraumFlaeche, 10, "Sanitärraum", sanitaerraumfeuerloecher);
            Bildung sportraum = new Bildung(sportraumFlaeche, 10, "Sportraum", sportraumfeuerloecher);
            Bildung unterrichtsraum = new Bildung(unterrichtsraumFlaeche, 10, "Unterrichtsraum", unterrichtsraumfeuerloecher);
            Bildung uebungsraum = new Bildung(uebungsraumFlaeche, 10, "Übungsraum", uebungsraumfeuerloecher);
            Bildung hoersaal = new Bildung(hoersaalFlaeche, 10, "Hörsaal", hoersaalfeuerloecher);
            Bildung bibliotheksraum = new Bildung(bibliotheksraumFlaeche, 10, "Bibliotheksraum", bibliotheksraumfeuerloecher);


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


    }
}
