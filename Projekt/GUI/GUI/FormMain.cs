using Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        private BindingList<Raum> raeume;
        private BindingList<Feuerloescher> feuerloescherList;
        public BindingList<Material> materialien;
        private listBoxRaumItems item;
        public FormMain(BindingList<Raum> _raeume, BindingList<Feuerloescher> _feuerloescherList, BindingList<Material> _materialien)
        {
            InitializeComponent();
            this.raeume = _raeume;
            this.feuerloescherList = _feuerloescherList;
            this.materialien = _materialien;
            fuelleListe();
        }

        private void fuelleListe()
        {

            if (comboBoxTypRaum.Items.IndexOf("Alle") == -1)
                comboBoxTypRaum.Items.Add("Alle");

            foreach (Raum r in raeume)
            {
                if (comboBoxTypRaum.Items.IndexOf(r.TypRaume) == -1)
                    comboBoxTypRaum.Items.Add(r.TypRaume);
            }

            comboBoxTypRaum.SelectedIndex = 0;    
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTypRaum_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUpdate();
        }

        private void buttonabbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void raumErstellen(Raum raum)
        {
            raeume.Add(raum);
            comboBoxTypRaum.SelectedItem = raum.TypRaume;
            listBoxUpdate();
            listBoxRaum.SelectedIndex = listBoxRaum.Items.Count - 1;
            item = listBoxRaum.Items[listBoxRaum.SelectedIndex] as listBoxRaumItems;
            FormRaum formRaum = new FormRaum(item.Raum, feuerloescherList, this);
            formRaum.ShowDialog();
        }

        public void raumAenderung(Raum raum)
        {
            item = listBoxRaum.Items[listBoxRaum.SelectedIndex] as listBoxRaumItems;
            raeume.Remove(item.Raum);
            raeume.Add(raum);
            comboBoxTypRaum.SelectedItem = raum.TypRaume;
            listBoxUpdate();
            listBoxRaum.SelectedIndex = listBoxRaum.Items.Count - 1;
        }


        private void buttonLoeschenRaum_Click(object sender, EventArgs e)
        {
            item = listBoxRaum.Items[listBoxRaum.SelectedIndex] as listBoxRaumItems;
            raeume.Remove(item.Raum);
            listBoxUpdate();
        }

        private void listBoxRaum_DrawItem(object sender, DrawItemEventArgs e)
        {
            item = listBoxRaum.Items[e.Index] as listBoxRaumItems;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Cyan);

            e.DrawBackground();
            e.Graphics.DrawString(item.Raum.Bezeichung, e.Font, new SolidBrush(item.RaumColor), new PointF(e.Bounds.X, e.Bounds.Y));
            e.DrawFocusRectangle();
        }
        private void listBoxUpdate()
        {
            listBoxRaum.Items.Clear();
            listBoxRaum.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxRaum.DrawItem += listBoxRaum_DrawItem;

            
            String typ = (String)comboBoxTypRaum.SelectedItem;
            double gesamptpreis = 0;
            if (typ.Equals("Alle"))
            {
                foreach (Raum r in raeume)
                {
                    int LEFeurloescher = 0;
                    foreach(Feuerloescher f in r.FeuerloescherList)
                    {
                        LEFeurloescher += f.Anzahl * f.Loescheinheit;
                        gesamptpreis += f.Anzahl * f.Preis;
                    }
                    if (LEFeurloescher>=r.Loeschmitteleinheiten)
                        listBoxRaum.Items.Add(new listBoxRaumItems(Color.Green, r));
                    else listBoxRaum.Items.Add(new listBoxRaumItems(Color.Red, r));
                }

                labelGesamptpreis.Text = "Gesamptpreis des Brandschutz für alle Räume";
                textBoxGesamptpreis.Text = Convert.ToString(gesamptpreis);
            }

            else
            {
                foreach (Raum r in raeume)
                {

                    if (r.TypRaume.Equals(typ))
                    {
                    int LEFeurloescher = 0;
                    foreach(Feuerloescher f in r.FeuerloescherList)
                    {
                        LEFeurloescher += f.Anzahl * f.Loescheinheit;
                        gesamptpreis += f.Anzahl * f.Preis;
                    }
                    if (LEFeurloescher>=r.Loeschmitteleinheiten)
                        listBoxRaum.Items.Add(new listBoxRaumItems(Color.Green, r));
                    else listBoxRaum.Items.Add(new listBoxRaumItems(Color.Red, r));
                    }
                }

                labelGesamptpreis.Text = "Gesamptpreis des Brandschutz für den Nutzungsart " + typ;
                textBoxGesamptpreis.Text = Convert.ToString(gesamptpreis);
            }

            if (listBoxRaum.Items.Count > 0)
            { 
                listBoxRaum.SelectedIndex = 0;
                buttonRaumDetail.Enabled = true;
                buttonLoeschenRaum.Enabled = true;
            }
            else
            {
                buttonRaumDetail.Enabled = false;
                buttonLoeschenRaum.Enabled = false;
            }



            
        }

        private void buttonRaumDetail_Click(object sender, EventArgs e)
        {
            item = listBoxRaum.Items[listBoxRaum.SelectedIndex] as listBoxRaumItems;
            FormRaum formRaum = new FormRaum(item.Raum, feuerloescherList, this);
            formRaum.ShowDialog();
        }

        private void speichernToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, raeume);
                fs.Close();
            }
        }

        private void ladenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                raeume = (BindingList<Raum>)bf.Deserialize(fs);
                fuelleListe();
                fs.Close();
            }
            listBoxUpdate();
        }

        private void buttonErstellenRaum_Click(object sender, EventArgs e)
        {
            FormNeuerRaum formNeuerRaum = new FormNeuerRaum(comboBoxTypRaum.SelectedIndex-1, this);
            formNeuerRaum.ShowDialog();
        }

        public static implicit operator int(FormMain v)
        {
            throw new NotImplementedException();
        }

        public double returnHeizwert(String typ)
        {
            double heizwert = 0;
            foreach (Raum r in raeume)
            {
                if (r.TypRaume.Equals(typ))
                {
                    heizwert = r.Heizwert;
                    break;
                }
            }
            return heizwert;
        }

        public Material returnMaterial(String bezeichnung)
        {
            Material material = new Material();
            foreach(Material m in materialien)
            {
                if (m.Bezeichnung.Equals(bezeichnung))
                {
                    return m;
                    break;
                }
            }
            return material;
        }


    }
}
