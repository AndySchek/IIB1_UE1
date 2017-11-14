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
            //textBoxRaumBrandgefahr.Text = Math.Round(raum.Brandgefahr,2).ToString();
            textBoxLoeschmeiiteleinheiten.Text = raum.Loeschmitteleinheiten.ToString();

            String typ = raum.TypRaume;

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
            raum.Flaeche = Convert.ToDouble(textBoxRaumFlaeche.Text);
            raum.Loeschmitteleinheiten = Convert.ToInt16(textBoxLoeschmeiiteleinheiten.Text);
            //raum.Feuerloecher.Loeschvermoegen.nameLoeschvermoegen = comboBoxLoeschvermoegen.Text;

            int art = 0;
            if (raum.TypRaume.Equals("Bueroarbeit"))
                art = 1;
            else if (raum.TypRaume.Equals("Bildung"))
                art = 2;

            int t = comboBoxRaumNutzungsart.SelectedIndex;
            /*
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
            */

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
    }
}
