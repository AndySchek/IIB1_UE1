using Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormFeuerloescher : Form
    {
        //private Raum raum;
        private Raum raum;
        private BindingList<Feuerloescher> feuerloescherList;
        Feuerloescher feuerloescher = new Feuerloescher();
        private double leRaum;
        private Boolean neuer = false;

        public FormFeuerloescher(Feuerloescher f, Raum _raum, BindingList<Feuerloescher> _feuerloescherList, FormRaum _parent)
        {
            InitializeComponent();
            this.raum = _raum;
            this.feuerloescherList = _feuerloescherList;
            this.Owner = _parent;
            this.leRaum = raum.Loeschmitteleinheiten;
            this.feuerloescher = f;
            fuelleBoxen();
        }

        private void fuelleBoxen()
        {
            comboBoxBezeichnungFeuerloescher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxBezeichnungFeuerloescher.Items.Clear();

            if (feuerloescher!=null)
            {
                this.Text = "Details Feuerlöschern";
                if (raum.FeuerloescherList.Count > 0)
                {
                    foreach (Feuerloescher f in raum.FeuerloescherList)
                    {
                        if (raum.FeuerloescherList.IndexOf(f) > -1)
                        {
                            comboBoxBezeichnungFeuerloescher.Items.Add(f);
                        }
                    }
                    comboBoxBezeichnungFeuerloescher.SelectedIndex = ((FormRaum)Owner).returnSelectedFeuerloscher();
                    trackBarAnzahlFeuerloescher.Value = feuerloescher.Anzahl;
                    buttonNeuerFeuerloescherSpeichern.Text = "Änderung speichern";
                    buttonFeuerloescherloeschen.Visible = true;
                    buttonFeuerloescherloeschen.Enabled = true;
                    buttonNeuerFeuerloescherSpeichern.Enabled = true;
                    comboBoxBezeichnungFeuerloescher.Enabled = true;
                    trackBarAnzahlFeuerloescher.Enabled = true;
                }
                else
                {
                    neuer = true;
                    buttonFeuerloescherloeschen.Enabled = false;
                    buttonNeuerFeuerloescherSpeichern.Enabled = false;
                    comboBoxBezeichnungFeuerloescher.Enabled = false;
                    trackBarAnzahlFeuerloescher.Enabled = false;
                }
            }
            else
            {
                buttonFeuerloescherloeschen.Visible = false;
                if (raum.FeuerloescherList.Count == feuerloescherList.Count)
                {
                    comboBoxBezeichnungFeuerloescher.Enabled = false;
                    buttonNeuerFeuerloescherSpeichern.Enabled = false;
                    trackBarAnzahlFeuerloescher.Enabled = false;
                }

                foreach (Feuerloescher f in feuerloescherList)
                {
                    if (raum.FeuerloescherList.IndexOf(f) == -1)
                    {
                            comboBoxBezeichnungFeuerloescher.Items.Add(f);
                    }
                }
                if(comboBoxBezeichnungFeuerloescher.Items.Count > 0)
                    comboBoxBezeichnungFeuerloescher.SelectedIndex = 0;
            }

            comboBoxBezeichnungFeuerloescher.DisplayMember = "Bezeichnung";

            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
            textBoxLERaum.Text = Convert.ToString(raum.Loeschmitteleinheiten);
            changedTextBoxen();
        }

        private void comboBoxBezeichnungFeuerloescher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (feuerloescher == null)
            {
                trackBarAnzahlFeuerloescher.Value = 1;
                feuerloescher = new Feuerloescher();
                neuer = true;
            }

            feuerloescher = (Feuerloescher)comboBoxBezeichnungFeuerloescher.SelectedItem;
            textBoxLEFeuerloescher.Text = Convert.ToString(feuerloescher.Loescheinheit);
            textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(feuerloescher.Preis);
            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
            if (!neuer) trackBarAnzahlFeuerloescher.Value = feuerloescher.Anzahl;
            changedTextBoxen();
        }

        private void trackBarAnzahlFeuerloescher_ValueChanged(object sender, EventArgs e)
        {

            changedTextBoxen();

        }

        private void buttonNeuerFeuerloescherSpeichern_Click(object sender, EventArgs e)
        {
            feuerloescher.Anzahl = trackBarAnzahlFeuerloescher.Value;
            feuerloescher.Bezeichnung = comboBoxBezeichnungFeuerloescher.Text;
            ((FormRaum)Owner).feuerloescherHinzufuegen(feuerloescher);
            if (neuer) feuerloescher = null;
            fuelleBoxen();
        }

        private void buttonabbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxLEFeuerloescher_TextChanged(object sender, EventArgs e)
        {
            changedTextBoxen();
        }

        private void changedTextBoxen()
        {
            int countFeuerloescher = 0;
            int leFeuerloeschen = 0;
            double preis = 0;
            int gesamtLE = 0;
            int benoetigeLE = 0;
            try
            {
                
                foreach (Feuerloescher f in raum.FeuerloescherList)
                {
                    if (f != feuerloescher)
                    {
                        countFeuerloescher += f.Anzahl;
                        leFeuerloeschen += f.Anzahl * f.Loescheinheit;
                        preis += f.Preis * f.Anzahl;
                        gesamtLE += f.Loescheinheit * f.Anzahl;
                    }
                    
                }
                benoetigeLE = raum.Loeschmitteleinheiten - (gesamtLE + trackBarAnzahlFeuerloescher.Value * feuerloescher.Loescheinheit);
                if (benoetigeLE < 0) benoetigeLE = 0;
                textBoxBenoetigeLE.Text = Convert.ToString(benoetigeLE);
                textBoxLEFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Loescheinheit);
                textBoxGesamtLE.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Loescheinheit + gesamtLE);
                textBoxAnzahlFeuerloschen.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value + countFeuerloescher);
                textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Preis + preis);
                labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);

            }
            catch
            {

            }
        }

        private void textBoxBenoetigeLE_TextChanged(object sender, EventArgs e)
        {
            int bLE = Convert.ToInt32(textBoxBenoetigeLE.Text);
            if (bLE==0) labelAnzahlFeuerloescher.ForeColor = Color.Green;
            else labelAnzahlFeuerloescher.ForeColor = Color.Red;
        }

        private void buttonFeuerloescherloeschen_Click(object sender, EventArgs e)
        {
            ((FormRaum)Owner).feuerloescheLoeschen(f: (Feuerloescher)comboBoxBezeichnungFeuerloescher.SelectedItem);
            fuelleBoxen();
        }
    }
}
