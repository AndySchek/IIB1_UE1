using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klassen;

namespace GUI
{
    public partial class FormRaum : Form
    {
        private Raum raum;
        public FormRaum(Raum _raum, FormMain _parent)
        {
            InitializeComponent();
            this.raum = _raum;
            this.Owner = _parent;
            fuelleBoxen();
        }

        private void fuelleBoxen()
        {
            textBoxRaumBezeichnung.Text = raum.Bezeichung;
            textBoxRaumFlaeche.Text = Math.Round(raum.Flaeche, 2).ToString();
            textBoxRaumBrandgefahr.Text = Math.Round(raum.Brandgefahr,2).ToString();

            String typ = raum.TypRaume;
            //List<String> raumTyp = ("Wohnung", "Buero", "Bildung");

            switch (typ)
            {
                case "Wohnung":
                    comboBoxRaumNutzungsart.SelectedIndex = 0;
                    break;
                case "Büroarbeit":
                    comboBoxRaumNutzungsart.SelectedIndex = 1;
                    break;
                case "Bildung":
                    comboBoxRaumNutzungsart.SelectedIndex = 2;
                    break;

            }

            //comboBoxRaumNutzungsart.SelectedIndex = t;
            //comboBoxRaumNutzungsart.Items.Add(raum.TypRaume);


            //textBoxGrenzwert.Text = Math.Round(r.GrenzwertRatio, 2).ToString();
            //textBoxFensterFlaeche.Text = Math.Round(r.fensterFlaeche(), 2).ToString();
            //int art = 0;
            //if (r is Wohnen)
            //    art = 1;
            //comboBoxRaumTyp.SelectedIndex = art;
            //listBoxFenster.DataSource = r.FensterListe;
            //listBoxFenster.DisplayMember = "Bezeichung";
        }

        private void buttonAenderungsSpeichern_Click(object sender, EventArgs e)
        {
            raum.Bezeichung = textBoxRaumBezeichnung.Text;

            int art = 0;
            if (raum.TypRaume.Equals("Bueroarbeit"))
                art = 1;
            else if (raum.TypRaume.Equals("Bildung"))
                art = 2;

            int t = comboBoxRaumNutzungsart.SelectedIndex;

            if (t != art)
            {
                switch (t)
                {
                    case 0:
                        Wohnung neuerWohnungRaum = new Wohnung(raum);
                        raum = neuerWohnungRaum;
                        break;
                    case 1:
                        Bueroarbeit neuerBueroarbeitRaum = new Bueroarbeit(raum);
                        raum = neuerBueroarbeitRaum;
                        break;
                    case 2:
                        Bildung neuerBildungRaum = new Bildung(raum);
                        raum = neuerBildungRaum;
                        break;
                }
            }

            ((FormMain)Owner).raumAenderung(raum);
        
        }
    }
}
