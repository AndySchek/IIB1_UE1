﻿using Klassen;
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
            Raum raum = new Raum();
            raum.Bezeichung = textBoxRaumBezeichnung.Text;

            try
            {
                raum.Flaeche = Double.Parse(textBoxRaumFlaeche.Text);
            }
            catch(Exception)
            {
                raum.Flaeche = 0.0;
            }

            raum.Loeschmitteleinheiten = raum.countLoeschmitteleinheiten(raum.Flaeche);

            int t = comboBoxRaumNutzungsart.SelectedIndex;

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

           ((FormMain)Owner).raumErstellen(raum);

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