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
    public partial class FormNeuerFeuerloescher : Form
    {
        //private Raum raum;
        private Raum raum;
        private BindingList<Feuerloescher> feuerloescherList;
        Feuerloescher feuerloescher;
        public FormNeuerFeuerloescher(Raum _raum, BindingList<Feuerloescher> _feuerloescherList, FormRaum _parent)
        {
            InitializeComponent();
            this.raum = _raum;
            this.feuerloescherList = _feuerloescherList;
            this.Owner = _parent;
            fuelleBoxen();
        }

        private void fuelleBoxen()
        {
            comboBoxBezeichnungFeuerloescher.Items.Clear();
            if (raum.FeuerloescherList.Count == feuerloescherList.Count)
            {
                comboBoxBezeichnungFeuerloescher.Enabled = false;
                buttonNeuerFeuerloescherSpeichern.Enabled = false;
                trackBarAnzahlFeuerloescher.Enabled = false;
                comboBoxBezeichnungFeuerloescher.Text = "Unerreichtbar";
                textBoxGesamptpreisFeuerloscher.Text = "";
                textBoxLEFeuerloescher.Text = "";
                labelAnzahlFeuerloescher.Text = "";
            }
            else
            {
                comboBoxBezeichnungFeuerloescher.Enabled = true;
                buttonNeuerFeuerloescherSpeichern.Enabled = true;
                trackBarAnzahlFeuerloescher.Enabled = true;
                foreach (Feuerloescher f in this.feuerloescherList)
                {
                    if (raum.FeuerloescherList.IndexOf(f) == -1)
                    {
                        comboBoxBezeichnungFeuerloescher.Items.Add(f);
                    }
                }

                if (comboBoxBezeichnungFeuerloescher.Items.Count > 0)
                {
                    comboBoxBezeichnungFeuerloescher.SelectedIndex = 0;
                }
                comboBoxBezeichnungFeuerloescher.DisplayMember = "Bezeichnung";

                labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
            }
        }

        private void comboBoxBezeichnungFeuerloescher_SelectedIndexChanged(object sender, EventArgs e)
        {
            feuerloescher = (Feuerloescher)comboBoxBezeichnungFeuerloescher.SelectedItem;
            trackBarAnzahlFeuerloescher.Value = 1;
            textBoxLEFeuerloescher.Text = Convert.ToString(feuerloescher.Loescheinheit);
            textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(feuerloescher.Preis);
            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
        }

        private void trackBarAnzahlFeuerloescher_ValueChanged(object sender, EventArgs e)
        {
            textBoxLEFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Loescheinheit);
            textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Preis);
            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
            feuerloescher.Anzahl = trackBarAnzahlFeuerloescher.Value;
        }

        private void buttonNeuerFeuerloescherSpeichern_Click(object sender, EventArgs e)
        {
            feuerloescher.Anzahl = trackBarAnzahlFeuerloescher.Value;
            ((FormRaum)Owner).feuerloescherHinzufuegen(feuerloescher);
            fuelleBoxen();
        }

        private void buttonabbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
