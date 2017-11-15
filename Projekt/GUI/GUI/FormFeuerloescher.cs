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
        private Feuerloescher feuerloecher;
        public FormRaum owner;
        public FormFeuerloescher(Feuerloescher _feuerloescher)
        {
            InitializeComponent();
            this.feuerloecher = _feuerloescher;
            //this.Owner = _parent;
            fuelleBoxen();
        }

        private void fuelleBoxen()
        {
            textBoxBezeichnungFeuerloescher.Text = feuerloecher.Bezeichnung;
            trackBarAnzahlFeuerloescher.Value = feuerloecher.Anzahl;
            textBoxLEFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloecher.Loescheinheit);
            textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloecher.Preis);
            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
        }

            private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBarAnzahlFeuerloescher_ValueChanged(object sender, EventArgs e)
        {
            labelAnzahlFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value);
            textBoxGesamptpreisFeuerloscher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloecher.Preis);
            textBoxLEFeuerloescher.Text = Convert.ToString(trackBarAnzahlFeuerloescher.Value * feuerloecher.Loescheinheit);
        }
    }
}
