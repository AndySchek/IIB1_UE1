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
    public partial class FormNeuerRaum : Form
    {
        
        //private Raum raum;
        public FormNeuerRaum(int _index, FormMain _parent)
        {
            InitializeComponent();
            this.Owner = _parent;
            textBoxRaumBezeichnung.Text = "Raum";
            textBoxRaumFlaeche.Text = "0,0";
            if (_index == -1) _index = 0;
            comboBoxRaumNutzungsart.SelectedIndex = _index;
            buttonNeuerRaum.Enabled = true;
            
        }

        private void buttonNeuerRaum_Click(object sender, EventArgs e)
        {
            
            int t = comboBoxRaumNutzungsart.SelectedIndex;
            
            switch (t)
            {
                case 0:
                    Buero newBuero = new Buero();
                    newBuero.Bezeichung = textBoxRaumBezeichnung.Text;
                    try
                    {
                        newBuero.Flaeche = Double.Parse(textBoxRaumFlaeche.Text);
                    }
                    catch (Exception)
                    {
                        newBuero.Flaeche = 0.0;
                    }
                    newBuero.Loeschmitteleinheiten = newBuero.countLoeschmitteleinheiten(newBuero.Flaeche);
                    ((FormMain)Owner).raumErstellen(newBuero);
                    break;
                case 1:
                    Flur newFlur = new Flur();
                    newFlur.Bezeichung = textBoxRaumBezeichnung.Text;
                    try
                    {
                        newFlur.Flaeche = Double.Parse(textBoxRaumFlaeche.Text);
                    }
                    catch (Exception)
                    {
                        newFlur.Flaeche = 0.0;
                    }
                    newFlur.Loeschmitteleinheiten = newFlur.countLoeschmitteleinheiten(newFlur.Flaeche);
                    ((FormMain)Owner).raumErstellen(newFlur);
                    break;
                case 2:
                    Seminarraum newSeminarraum = new Seminarraum();
                    newSeminarraum.Bezeichung = textBoxRaumBezeichnung.Text;
                    try
                    {
                        newSeminarraum.Flaeche = Double.Parse(textBoxRaumFlaeche.Text);
                    }
                    catch (Exception)
                    {
                        newSeminarraum.Flaeche = 0.0;
                    }
                    newSeminarraum.Loeschmitteleinheiten = newSeminarraum.countLoeschmitteleinheiten(newSeminarraum.Flaeche);
                    ((FormMain)Owner).raumErstellen(newSeminarraum);
                    break;
                case 3:
                    Sanitaerraum newSanitaerraum = new Sanitaerraum();
                    newSanitaerraum.Bezeichung = textBoxRaumBezeichnung.Text;
                    try
                    {
                        newSanitaerraum.Flaeche = Double.Parse(textBoxRaumFlaeche.Text);
                    }
                    catch (Exception)
                    {
                        newSanitaerraum.Flaeche = 0.0;
                    }
                    newSanitaerraum.Loeschmitteleinheiten = newSanitaerraum.countLoeschmitteleinheiten(newSanitaerraum.Flaeche);
                    ((FormMain)Owner).raumErstellen(newSanitaerraum);
                    break;
            }      
          


        }

        private void textBoxRaumFlaeche_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxRaumBezeichnung_TextChanged(object sender, EventArgs e)
        {
            buttonNeuerRaumEnabled();
        }

        private void textBoxRaumFlaeche_TextChanged(object sender, EventArgs e)
        {
            buttonNeuerRaumEnabled();
            int max = 2147483632;
            if (textBoxRaumFlaeche.Text != "")
            {
                double change = Convert.ToDouble(textBoxRaumFlaeche.Text);

                if (change > max) textBoxRaumFlaeche.Text = "2147483632";
            }

        }

        private void buttonNeuerRaumEnabled()
        {
         
            if ((textBoxRaumBezeichnung.TextLength > 0) && (textBoxRaumFlaeche.TextLength > 0)) buttonNeuerRaum.Enabled = true;
            else buttonNeuerRaum.Enabled = false;

        }
    }
}
