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
        private static IList<Element> alleBoeden = new List<Element>();

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
            Klassen.Material material = getMaterial(room); 
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
                Flur flur = new Flur(flaeche, room.Number, feuerloescherListe, material);
                return flur;
            }
            return null;
        }

        public static Klassen.Material getMaterial(Room room)
        {


            List<FamilyInstance> alleBodenMaterialien = new List<FamilyInstance>();
            foreach (Element e in alleBoeden)
            {
                FamilyInstance fi = (FamilyInstance)e;
                if (fi.Room != null && fi.Room.Number.Equals(room.Number)) {
                    alleBoeden.Add(fi);
                    
                }
            }
            Klassen.Material material= new Klassen.Material();


            if (alleBoeden != null)
            {
                foreach (FamilyInstance fi in alleBoeden)
                {

                }
            }

            return material;
        }


        /// <summary>
        /// Sucht alle Elemente der Kategorie Boden aus dem Bauwerk.
        /// </summary>
        /// <param name="alleElemente">Liste aller Böden.</param>
        public static void alleBoedensuchen()
        {
            ElementCategoryFilter floorFilter = new ElementCategoryFilter(BuiltInCategory.OST_Floors);

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            alleBoeden = collector.WherePasses(floorFilter).WhereElementIsNotElementType().ToElements();
        }
        

        public static double squarefeetToQuadratmeter(double squarefeet)
        {
            double quadratmeter = (squarefeet / 10.7639);
            return Math.Round(quadratmeter, 2);
        }
        #endregion

	}
}
