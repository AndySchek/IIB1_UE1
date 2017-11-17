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
    public partial class FormFeuerloescher : Form
    {
        private Feuerloescher feuerloescher;
        public FormRaum Owner;
        public FormFeuerloescher(Feuerloescher _feuerloescher, FormRaum _parent)
        {
            InitializeComponent();
            this.feuerloescher = _feuerloescher;
            this.Owner = _parent;
            fuelleBoxen();
        }

        private void fuelleBoxen()
        {
            textBoxBezeichnungFeuerloescher.Text = feuerloescher.Bezeichnung;
            trackBarAnzahlFeuerloescher.Value = feuerloescher.Anzahl;
            textBoxLEFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Loescheinheit);
            textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Preis);
            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
        }

            private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBarAnzahlFeuerloescher_ValueChanged(object sender, EventArgs e)
        {
            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
            textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Preis);
            textBoxLEFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloescher.Loescheinheit);
        }

        private void buttonAenderungFeuerloescherSpeichern_Click(object sender, EventArgs e)
        {
            feuerloescher.Anzahl = trackBarAnzahlFeuerloescher.Value;
            ((FormRaum)Owner).feuerloescherAenderung(feuerloescher);
        }

        private void buttonFeuerloescherloeschen_Click(object sender, EventArgs e)
        {
            ((FormRaum)Owner).feuerloescheLoeschen();
            this.Close();
        }
    }
}
