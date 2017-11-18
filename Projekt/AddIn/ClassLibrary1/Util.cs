using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen;
using GUI;

namespace IIB1_UE1AddIn
{
	class Util
	{
		#region Attribute
        private static Document doc = null;
        private static IList<Element> alleElemente = new List<Element>();

        public static Document Doc
        {
            set
            {
                doc = value;
            }
        }
        #endregion

        #region Methoden
        /// <summary>
        /// Parst einen Revit-Raum in einen Raum-Raum.
        /// </summary>
        /// <param name="room">Raum, der geparst werden soll.</param>
        /// <returns>Den Raum als Instanz der Klasse Raum</returns>
        public static Raum parseRaum(Room room)
        {
            /*List<FamilyInstance> revitFensterListe = findeAlleRaumFenster(room);
            BindingList<Fenster> fensterListe = parseFenster(revitFensterListe);*/
            BindingList<Feuerloescher> feuerloescherListe = new BindingList<Feuerloescher>();
            BindingList <Klassen.Material> materialListe = getMaterials(room); 
            double flaeche = squarefeetToQuadratmeter(room.Area);
            string raumtyp = room.GetParameters("Nutzungsgruppe DIN 277-2")[0].AsString();
            if (raumtyp == "2-Büroarbeit")
            {
                Buero buero = new Buero();
                return buero;
            }
            else if (raumtyp == "5-Bildung, Unterricht und Kultur")
            {
                Seminarraum seminarraum = new Seminarraum();
                return seminarraum;
            }
            else if (raumtyp == "7-Sonstige Nutzungen")
            {
                Sanitaerraum sanitaerraum = new Sanitaerraum();
                return sanitaerraum;
            }
            else if (raumtyp == "9-Verkehrserschließung und -sicherung")
            {
                Flur flur = new Flur(flaeche, room.Number, feuerloescherListe, materialListe);
                return flur;
            }
            return null;
        }

        public static BindingList<Klassen.Material> getMaterials(Room room)
        {
            return 
        }

        /// <summary>
        /// Parst eine Revit-Fensterliste in ein Fenster-Fensterliste.
        /// </summary>
        /// <param name="revitFensterListe">liste von Fenster, die geparst werden soll.</param>
        /// <returns>Eine Liste der Fenster eines Raumes</returns>
        /*
        private static BindingList<Material> parseMaterial(List<FamilyInstance> revitFensterListe)
        {
            if (revitFensterListe != null)
            {
                BindingList<Fenster> fensterListe = new BindingList<Fenster>();
                foreach (FamilyInstance fi in revitFensterListe)
                {
                    double fensterFlaeche = groessteFensterflaeche(fi);
                    Fenster fenster = new Fenster(Util.squarefeetToQuadratmeter(
              fensterFlaeche), fi.Name, fi.Symbol.ToString());
                    fensterListe.Add(fenster);
                }
                return fensterListe;
            }
            return null;
        }*/

        public static void holeAlleGegenstaende()
        {
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Furniture);
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            alleElemente = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();
        }

        /// <summary>
        /// Holt alle Gegenstände, die in den Waenden des ausgesuchten Zimmers sind.  
        /// </summary>
        /// <param name="room">Raum, der untersucht werden soll.</param>
        /// <returns>Den Raum als Instanz der Klasse Raum</returns>
        private static List<FamilyInstance> findeAlleRaumGegenstaende(Room room)
        {
            List<FamilyInstance> alleRaumGegenstaende = new List<FamilyInstance>();
            foreach (Element e in alleElemente)
            {
                FamilyInstance fi = (FamilyInstance)e;
                if ((fi.ToRoom != null && fi.ToRoom.Number.Equals(room.Number)) || (fi.FromRoom != null && fi.FromRoom.Number.Equals(room.Number)))
                    alleRaumGegenstaende.Add(fi);
            }
            return alleRaumGegenstaende;
        }

        public static double squarefeetToQuadratmeter(double squarefeet)
        {
            double quadratmeter = (squarefeet / 10.7639);
            return Math.Round(quadratmeter, 2);
        }
        #endregion

	}
}
