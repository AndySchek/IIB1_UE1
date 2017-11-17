﻿using System;
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
        String gesamptpreis = "0";
        private Material material;
        public FormRaum(Raum _raum, BindingList<Feuerloescher> _feuerloescherList, FormMain _parent)
        {
            InitializeComponent();
            this.raum = _raum;
            this.feuerloescherList = _feuerloescherList;
            this.Owner = _parent;
            this.material = _raum.Materialien;
            fuelleBoxen();
        }

        private void fuelleBoxen()
        {
            textBoxRaumBezeichnung.Text = raum.Bezeichung;
            textBoxRaumFlaeche.Text = Math.Round(raum.Grundflaeche, 2).ToString();
            textBoxLoeschmeiiteleinheiten.Text = raum.Loeschmitteleinheiten.ToString();
            textBoxHeizwertRaum.Text = Convert.ToString(raum.Heizwert);

            textBoxMaterialDichte.Text = Convert.ToString(this.material.Dichte);
            textBoxGesamptdickeMaterial.Text = Convert.ToString(this.material.Gesamtdicke);
            textBoxFlaecheMaterial.Text = Convert.ToString(this.material.Flaeche);

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

            String material = raum.Materialien.Bezeichnung;

            switch (material)
            {
                case "Beton":
                    comboBoxMaterial.SelectedIndex = 0;
                    break;
                case "Gipskartonplatten":
                    comboBoxMaterial.SelectedIndex = 1;
                    break;
                case "Holzwolle-Leichtbauplatte":
                    comboBoxMaterial.SelectedIndex = 2;
                    break;
                case "Holz":
                    comboBoxMaterial.SelectedIndex = 3;
                    break;

            }
            brandlastUpdate();
            //textBoxMaterialDichte.Text = Convert.ToString(raum.Materialien.Dichte);
            //textBoxGesamptdickeMaterial.Text = Convert.ToString(raum.Materialien.Gesamtdicke);
            //textBoxFlaecheMaterial.Text = Convert.ToString(raum.Materialien.Flaeche);
            //raum.Materialien.BrandbareMasse = raum.Materialien.Dichte * raum.Materialien.Gesamtdicke * raum.Materialien.Flaeche;
            //textBoxBrandbareMasse.Text = Convert.ToString(raum.Materialien.BrandbareMasse);
            //raum.Brandlast = raum.Materialien.BrandbareMasse * raum.Heizwert;
            //textBoxBrandlastRaum.Text = Convert.ToString(raum.Brandlast);
            feuerloescherUpdate(0);

        }

        private void feuerloescherUpdate(int index)
        {
            listBoxFeuerlocher.Items.Clear();
            listBoxLE.Items.Clear();
            listBoxPreisFeuerloescher.Items.Clear();
            listBoxCountFeuerloescher.Items.Clear();
            listBoxPreisSummaFeuerloscher.Items.Clear();

            int anzahl = 0;
            double summe = 0;
            int le = 0;
            foreach (Feuerloescher fl in raum.FeuerloescherList)
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

            gesamptpreis = Convert.ToString(summe);
            listBoxFeuerlocher.DisplayMember = "Bezeichnung";
            if (raum.FeuerloescherList.Count > 0)
            {
                listBoxFeuerlocher.SelectedIndex = index;
                listBoxLE.SelectedIndex = index;
                listBoxPreisFeuerloescher.SelectedIndex = index;
                listBoxCountFeuerloescher.SelectedIndex = index;
                listBoxPreisSummaFeuerloscher.SelectedIndex = index;
                buttonFeuerloescherDetails.Enabled = true;
                buttonFeuerloescherloeschen.Enabled = true;
                buttonFeuerloescherDetails.BackColor = Color.FromName("Gold");
                buttonFeuerloescherloeschen.BackColor = Color.FromName("LightCoral");
                if (raum.FeuerloescherList.Count == this.feuerloescherList.Count)
                {
                    buttonNeuerFeuerloescherhinzufuegen.Enabled = false;
                    buttonNeuerFeuerloescherhinzufuegen.BackColor = DefaultBackColor;
                }

            }
            else
            {
                buttonNeuerFeuerloescherhinzufuegen.Enabled = true;
                buttonNeuerFeuerloescherhinzufuegen.BackColor = Color.FromName("LightGreen"); ;
                buttonFeuerloescherDetails.Enabled = false;
                buttonFeuerloescherloeschen.Enabled = false;
                buttonFeuerloescherDetails.BackColor = DefaultBackColor;
                buttonFeuerloescherloeschen.BackColor = DefaultBackColor;
            }

            textBoxLESumme.Text = Convert.ToString(le);
            textBoxAnzahlSumme.Text = Convert.ToString(anzahl);
            textBoxGesamptpreis.Text = Convert.ToString(summe);

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
            raum.Materialien = material;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonFeuerloescherDetails_Click(object sender, EventArgs e)
        {
            rufeFormFeuerloescherAuf(f: (Feuerloescher)listBoxFeuerlocher.SelectedItem);
        }

        private void rufeFormFeuerloescherAuf(Feuerloescher f = null)
        {
            FormFeuerloescher fFeuerloescher = new FormFeuerloescher(f, this);
            fFeuerloescher.ShowDialog();
        }

        private void buttonFeuerloescherloeschen_Click(object sender, EventArgs e)
        {
            feuerloescheLoeschen();
        }

        public void feuerloescheLoeschen()
        {
            raum.FeuerloescherList.Remove((Feuerloescher)listBoxFeuerlocher.SelectedItem);
            feuerloescherUpdate(0);
        }

        public void feuerloescherAenderung(Feuerloescher feuerloescher)
        {
            feuerloescherList[listBoxFeuerlocher.SelectedIndex].Anzahl = feuerloescher.Anzahl;
            feuerloescherUpdate(listBoxFeuerlocher.SelectedIndex);
        }

        public void feuerloescherHinzufuegen(Feuerloescher feuerloescher)
        {
            raum.FeuerloescherList.Add(feuerloescher);
            feuerloescherUpdate(0);
        }

        private void listBoxFeuerlocher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxFeuerlocher.SelectedIndex;
            listBoxLE.SelectedIndex = index;
            listBoxPreisFeuerloescher.SelectedIndex = index;
            listBoxCountFeuerloescher.SelectedIndex = index;
            listBoxPreisSummaFeuerloscher.SelectedIndex = index;
        }

        private void listBoxLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxLE.SelectedIndex;
            listBoxFeuerlocher.SelectedIndex = index;
            listBoxPreisFeuerloescher.SelectedIndex = index;
            listBoxCountFeuerloescher.SelectedIndex = index;
            listBoxPreisSummaFeuerloscher.SelectedIndex = index;

        }

        private void listBoxCountFeuerloescher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxCountFeuerloescher.SelectedIndex;
            listBoxFeuerlocher.SelectedIndex = index;
            listBoxLE.SelectedIndex = index;
            listBoxPreisFeuerloescher.SelectedIndex = index;
            listBoxPreisSummaFeuerloscher.SelectedIndex = index;
        }

        private void listBoxPreisFeuerloescher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxPreisFeuerloescher.SelectedIndex;
            listBoxFeuerlocher.SelectedIndex = index;
            listBoxLE.SelectedIndex = index;
            listBoxCountFeuerloescher.SelectedIndex = index;
            listBoxPreisSummaFeuerloscher.SelectedIndex = index;
        }

        private void listBoxPreisSummaFeuerloscher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxPreisSummaFeuerloscher.SelectedIndex;
            listBoxFeuerlocher.SelectedIndex = index;
            listBoxLE.SelectedIndex = index;
            listBoxCountFeuerloescher.SelectedIndex = index;
            listBoxPreisSummaFeuerloscher.SelectedIndex = index;
        }

        private void buttonNeuerFeuerloescherhinzufuegen_Click(object sender, EventArgs e)
        {
            FormNeuerFeuerloescher fNewFeuerloescher = new FormNeuerFeuerloescher(raum, feuerloescherList, this);
            fNewFeuerloescher.ShowDialog();
        }

        private void buttonabbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxLoeschmeiiteleinheiten_TextChanged(object sender, EventArgs e)
        {
            //progressBarBrandschutz();
            progressBarBrandschutzplanung.Maximum = Convert.ToInt32(textBoxLoeschmeiiteleinheiten.Text);
            progressBarBrandschutz();
        }

        private void textBoxLESumme_TextChanged(object sender, EventArgs e)
        {
            progressBarBrandschutz();

        }

        private void progressBarBrandschutz()
        {
            int LEFeuerloeschern = 0, LERaum = 0;
            if (textBoxLoeschmeiiteleinheiten.Text != "")
                LERaum = Convert.ToInt32(textBoxLoeschmeiiteleinheiten.Text);
            if (textBoxLESumme.Text != "")
                LEFeuerloeschern = Convert.ToInt32(textBoxLESumme.Text);
            progressBarBrandschutzplanung.Maximum = LERaum;

            if (LEFeuerloeschern <= LERaum)
            {
                progressBarBrandschutzplanung.Value = LEFeuerloeschern;
            }
            else
            {
                progressBarBrandschutzplanung.Value = LERaum;
            }
            int prozent = LEFeuerloeschern * 100 / LERaum;
            if (prozent >= 100)
            {
                labelProgressBar.ForeColor = Color.FromName("ForestGreen");
                textBoxInfoBrandschutz.ForeColor = Color.FromName("ForestGreen");
                textBoxInfoBrandschutz.Text = Convert.ToString("Sehr geehrter Nutzer," + Environment.NewLine + Environment.NewLine + "Ihre Planung an den Brandschutz ist erfolgreich erfüllt. Nun ist die Anzahl der Feuerlöschern ist genug für den Raum." + Environment.NewLine + Environment.NewLine + "Die Kosten für Brandschutz beträgt " + gesamptpreis + "€.");
            }
            else
            {
                labelProgressBar.ForeColor = Color.FromName("Red");
                textBoxInfoBrandschutz.ForeColor = Color.FromName("Red");
                textBoxInfoBrandschutz.Text = Convert.ToString("Sehr geehrter Nutzer," + Environment.NewLine + Environment.NewLine + "Ihre Planung an den Brandschutz ist nicht erfolgreich erfüllt. Die Anzahl der Feuerlöschern ist nicht genug für den Raum. Sie sollen mehr die Feuerlöschern zur Verbesserung des Brandschutz hinzugefügen.");

            }
            labelProgressBar.Text = Convert.ToString("Löschmitteleinheit " + LEFeuerloeschern + " aus " + LERaum + " | " + prozent + "% Brandschutz");
        }

        private void textBoxGesamptpreis_TextChanged(object sender, EventArgs e)
        {
            gesamptpreis = textBoxGesamptpreis.Text;
        }

        private void comboBoxRaumNutzungsart_SelectedIndexChanged(object sender, EventArgs e)
        {

            String typ = comboBoxRaumNutzungsart.Text;
            raum.Heizwert = ((FormMain)Owner).returnHeizwert(typ);
            textBoxHeizwertRaum.Text = Convert.ToString(raum.Heizwert);
            brandlastUpdate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            brandlastUpdate();
        }

        public void brandlastUpdate()
        {
            String bezeichnung = comboBoxMaterial.Text;
            material = ((FormMain)Owner).returnMaterial(bezeichnung);
            textBoxMaterialDichte.Text = Convert.ToString(material.Dichte);
            textBoxGesamptdickeMaterial.Text = Convert.ToString(material.Gesamtdicke);
            textBoxFlaecheMaterial.Text = Convert.ToString(material.Flaeche);
            material.BrandbareMasse = material.Dichte * material.Gesamtdicke * material.Flaeche;
            textBoxBrandbareMasse.Text = Convert.ToString(material.BrandbareMasse);
            raum.Brandlast = raum.Materialien.BrandbareMasse * raum.Heizwert;
            textBoxBrandlastRaum.Text = Convert.ToString(raum.Brandlast);
        }



        private void rechnungBrandlast()
        {
            //brandlastUpdate();
            /* String dichte = textBoxMaterialDichte.Text;
             String gesamtdicke = textBoxGesamptdickeMaterial.Text;
             String flaeche = textBoxFlaecheMaterial.Text;

             if (dichte != "")
                 material.Dichte = Convert.ToDouble(textBoxMaterialDichte.Text);
             else material.Dichte = 0;

             if (gesamtdicke != "")
                 material.Gesamtdicke = Convert.ToDouble(textBoxGesamptdickeMaterial.Text);
             else material.Gesamtdicke = 0;

             if (flaeche != "")
                 material.Flaeche = Convert.ToDouble(textBoxFlaecheMaterial.Text);
             else material.Flaeche = 0;
             */

            //brandlastUpdate();
            /*
            String dichte = textBoxMaterialDichte.Text;
            if (dichte != "")
                material.Dichte = Convert.ToDouble(textBoxMaterialDichte.Text);
            else material.Dichte = 0;
            */

            /*String gesamptdicke = textBoxGesamptdickeMaterial.Text;
            if (gesamptdicke != "")
                material.Gesamtdicke = Convert.ToDouble(textBoxGesamptdickeMaterial.Text);
            else material.Gesamtdicke = 0;
            */
            brandlastUpdateTextBox();
        }

        public void brandlastUpdateTextBox()
        {
            material.BrandbareMasse = material.Dichte * material.Gesamtdicke * material.Flaeche;
            textBoxBrandbareMasse.Text = Convert.ToString(material.BrandbareMasse);
            raum.Brandlast = material.BrandbareMasse * raum.Heizwert;
            textBoxBrandlastRaum.Text = Convert.ToString(raum.Brandlast);
        }

        private void textBoxMaterialDichte_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxMaterialDichte_TextChanged(object sender, EventArgs e)
        {
            String dichte = textBoxMaterialDichte.Text;
            if (dichte != "")
                material.Dichte = Convert.ToDouble(dichte);
            else material.Dichte = 0;
            brandlastUpdateTextBox();
        }

        private void textBoxGesamptdickeMaterial_TextChanged(object sender, EventArgs e)
        {
            String gesamptDicke = textBoxGesamptdickeMaterial.Text;
            if (gesamptDicke != "")
                material.Gesamtdicke = Convert.ToDouble(gesamptDicke);
            else material.Gesamtdicke = 0;
            brandlastUpdateTextBox();
        }

        private void textBoxFlaecheMaterial_TextChanged(object sender, EventArgs e)
        {
            String flaeche = textBoxFlaecheMaterial.Text;
            if (flaeche != "")
                material.Flaeche = Convert.ToDouble(flaeche);
            else material.Flaeche = 0;
            brandlastUpdateTextBox();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBrandlastRaum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
