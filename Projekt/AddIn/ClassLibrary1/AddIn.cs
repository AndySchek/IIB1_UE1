using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Architecture;
using System.ComponentModel;
using Klassen;
using GUI;
namespace IIB1_UE1AddIn
{
    public class AddIn
    {
		[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
		public class RevitAddIn : IExternalCommand
		{
			private static BindingList<Raum> meineRaeume = new BindingList<Raum>();
            private static BindingList<Feuerloescher> feuerloescher = new BindingList<Feuerloescher>();
            private static BindingList<Klassen.Material> material = new BindingList<Klassen.Material>();

			public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
			{
				try
				{

					UIApplication uiApp = commandData.Application;
					UIDocument mdoc = uiApp.ActiveUIDocument;
					Util.Doc = mdoc.Document;

					List<Element> Rooms = new FilteredElementCollector(mdoc.Document).OfClass(typeof(SpatialElement)).
						WhereElementIsNotElementType().Where(room => room.GetType() == typeof(Room)).ToList();
					BindingList<Raum> raeume = new BindingList<Raum>();
					foreach (Element e in Rooms)
					{
						Raum r = Util.parseRaum((Room)e);
						if (r != null)
							meineRaeume.Add(r);
					}
					FormMain m = new FormMain(meineRaeume, feuerloescher, material);
					m.ShowDialog();
					return Autodesk.Revit.UI.Result.Succeeded;
				}
				catch (Exception e) { return Result.Failed; }
			}

		}

	}
}
