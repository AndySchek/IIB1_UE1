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
        private BindingList<Feuerloescher> feuerloescherList;
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
            textBoxRaumFlaeche.Text = Math.Round(raum.Grundflaeche, 2).ToString();
            textBoxLoeschmeiiteleinheiten.Text = raum.Loeschmitteleinheiten.ToString();

            String typ = raum.TypRaume;

            switch (typ)
            {
                case "Büro":
                    comboBoxRaumNutzungsart.SelectedIndex = 0;
                    break;
                case "Flur":
                    comboBoxRaumNutzungsart.SelectedIndex = 1;
                    break;
                case "Seminarraum":
                    comboBoxRaumNutzungsart.SelectedIndex = 2;
                    break;
                case "Sanitärraum":
                    comboBoxRaumNutzungsart.SelectedIndex = 3;
                    break;

            }

            int anzahl = 0;
            double summe = 0;
            int le = 0;
            foreach(Feuerloescher fl in raum.FeuerloecherList)
            {
                double k = fl.Anzahl * fl.Preis;

                listBoxFeuerlocher.Items.Add(fl);
                listBoxLE.Items.Add(fl.Loescheinheit);
                listBoxPreisFeuerloescher.Items.Add(fl.Preis);
                listBoxCountFeuerloescher.Items.Add(fl.Anzahl);
                listBoxPreisSummaFeuerloscher.Items.Add(k);

                anzahl += fl.Anzahl;
                le += fl.Loescheinheit * fl.Anzahl;
                summe += k;
            }
        

            listBoxFeuerlocher.DisplayMember = "Bezeichnung";
            if (raum.FeuerloecherList.Count > 0)
            {
                listBoxFeuerlocher.SelectedIndex = 0;
            }
            
            textBoxLESumme.Text = Convert.ToString(le);
            textBoxAnzahlSumme.Text = Convert.ToString(anzahl);
            textBoxGesamptpreis.Text = Convert.ToString(summe);


            /*
            foreach (Loeschvermoegen l in raum.Feuerloecher.LoeschvermoegenList)
            {
                if (comboBoxLoeschvermoegen.Items.IndexOf(l.nameLoeschvermoegen) == -1)
                    comboBoxLoeschvermoegen.Items.Add(l.nameLoeschvermoegen);
            }

            String losch = raum.Feuerloecher.Loeschvermoegen.nameLoeschvermoegen;

            comboBoxLoeschvermoegen.SelectedIndex = comboBoxLoeschvermoegen.Items.IndexOf(raum.Feuerloecher.Loeschvermoegen.nameLoeschvermoegen);
            textBoxLE.Text = Convert.ToString(raum.Feuerloecher.Loeschvermoegen.countLoeschmitteleinheiten);

            rechnungCountFeuerloescher();
            */

        }

        private void buttonAenderungsSpeichern_Click(object sender, EventArgs e)
        {
            raum.Bezeichung = textBoxRaumBezeichnung.Text;
            raum.Grundflaeche = Convert.ToDouble(textBoxRaumFlaeche.Text);
            raum.Loeschmitteleinheiten = Convert.ToInt32(textBoxLoeschmeiiteleinheiten.Text);
            //raum.Feuerloecher.Loeschvermoegen.nameLoeschvermoegen = comboBoxLoeschvermoegen.Text;
            String typ = comboBoxRaumNutzungsart.Text;
            raum.TypRaume = typ;
            switch (typ)
            {
                case "Büro":
                    Buero newBuero = new Buero(raum);
                    raum = newBuero;
                    break;
                case "Flur":
                    Flur newFlur = new Flur(raum);
                    raum = newFlur;
                    break;
                case "Seminarraum":
                    Seminarraum newSeminarraum = new Seminarraum(raum);
                    raum = newSeminarraum;
                    break;
                case "Sanitärraum":
                    Sanitaerraum newSanitaerraum = new Sanitaerraum(raum);
                    break;
            }         

            ((FormMain)Owner).raumAenderung(raum);
        
        }

        private void textBoxRaumFlaeche_TextChanged(object sender, EventArgs e)
        {
            buttonAnderungEnabled();
            int max = 2147483632;
            if (textBoxRaumFlaeche.Text != "")
            {
                double change = Convert.ToDouble(textBoxRaumFlaeche.Text);

                if (change > max) textBoxLoeschmeiiteleinheiten.Text = "Error";
                else
                {
                    textBoxLoeschmeiiteleinheiten.Text = Convert.ToString(raum.countLoeschmitteleinheiten(change));
                }
            }
            else
            {
                textBoxLoeschmeiiteleinheiten.Text = "0";
            }

            rechnungCountFeuerloescher();


        }

        private void textBoxRaumBezeichnung_TextChanged(object sender, EventArgs e)
        {
            buttonAnderungEnabled();
        }

        private void buttonAnderungEnabled()
        {

            if ((textBoxRaumBezeichnung.TextLength > 0) && (textBoxRaumFlaeche.TextLength > 0)) buttonAenderungsSpeichern.Enabled = true;
            else buttonAenderungsSpeichern.Enabled = false;

        }

        private void textBoxRaumFlaeche_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void FormRaum_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxLoeschvermoegen_SelectedIndexChanged(object sender, EventArgs e)
        {
            String loeschvermoegen = (String)comboBoxLoeschvermoegen.SelectedItem;
            int countLoeschmitteleinheiten = 0;

            /*
            foreach (Loeschvermoegen l in raum.Feuerloecher.LoeschvermoegenList)
            {
                if (loeschvermoegen.Equals(l.nameLoeschvermoegen))
                {
                    textBoxLE.Text = Convert.ToString(l.countLoeschmitteleinheiten);
                    countLoeschmitteleinheiten = l.countLoeschmitteleinheiten;
                    break;
                }
            }
            rechnungCountFeuerloescher();
            */

        }

        private void textBoxLoeschmeiiteleinheiten_TextChanged(object sender, EventArgs e)
        {

        }

        private void rechnungCountFeuerloescher()
        {
            int LoeschmeiiteleinheitenRaum = Convert.ToInt32(textBoxLoeschmeiiteleinheiten.Text);
            int LoeschmeiiteleinheitenFeuerlosher = 0;
            String ss = textBoxLE.Text;
            if (ss == "")
            {
                LoeschmeiiteleinheitenFeuerlosher = 0;
            }
            else LoeschmeiiteleinheitenFeuerlosher = Convert.ToInt32(ss);
            double countFeuerloescher = Math.Ceiling((Double)LoeschmeiiteleinheitenRaum / LoeschmeiiteleinheitenFeuerlosher);
            if (countFeuerloescher == 0) countFeuerloescher = 1;
            textBoxCountFeuerloescher.Text = Convert.ToString(countFeuerloescher);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonFeuerloescherDetails_Click(object sender, EventArgs e)
        {
            //FormFeuerloescher formFeuerloescher = new FormFeuerloescher((Feuerlocher)listBoxFeuerlocher.SelectedItem, this);
            //formFeuerloescher.ShowDialog();
            //FormFeuerloescher formFeuerloescher = new FormFeuerloescher((Feuerloecher)listBoxFeuerlocher.Items, this);
            //formFeuerloescher.Owner = this;
            //formFeuerloescher.ShowDialog();
            rufeFormFeuerloescherAuf(f: (Feuerloescher)listBoxFeuerlocher.SelectedItem);
        }

        private void rufeFormFeuerloescherAuf(Feuerloescher f = null)
        {
            FormFeuerloescher fFeuerloescher = new FormFeuerloescher(f);
            fFeuerloescher.owner = this;
            fFeuerloescher.ShowDialog();
        }

        private void buttonFeuerloescherloeschen_Click(object sender, EventArgs e)
        {
            // .Remove((Feuerlocher)listBoxFeuerlocher.SelectedItem);
            raum.FeuerloecherList.Remove((Feuerloescher)listBoxFeuerlocher.SelectedItem);
        }
    }
}
