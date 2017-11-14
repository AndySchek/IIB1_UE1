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

        public FormMain(BindingList<Raum> _raeume)
        {
            InitializeComponent();
            this.raeume = _raeume;
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

        public void raumAenderung(Raum raum)
        {
            raeume.Remove((Raum)listBoxRaum.SelectedItem);
            raeume.Add(raum);
            comboBoxTypRaum.SelectedIndex = 0;
            listBoxUpdate();
            listBoxRaum.SelectedItem = raum;
        }

        public void raumErstellen(Raum raum)
        {
            raeume.Add(raum);
            listBoxUpdate();
            comboBoxTypRaum.SelectedIndex = 0;
            listBoxRaum.SelectedItem = raum;
        }


        private void buttonLoeschenRaum_Click(object sender, EventArgs e)
        {
            raeume.Remove((Raum)listBoxRaum.SelectedItem);
            listBoxUpdate();
        }

        private void listBoxUpdate()
        {
            listBoxRaum.Items.Clear();
            String typ = (String)comboBoxTypRaum.SelectedItem;

            if (typ.Equals("Alle"))
            {
                foreach (Raum r in raeume)
                {
                    listBoxRaum.Items.Add(r);
                }
            }

            else
            {
                foreach (Raum r in raeume)
                {

                    if (r.TypRaume.Equals(typ))
                    {
                        listBoxRaum.Items.Add(r);
                    }
                }
            }
            listBoxRaum.DisplayMember = "Bezeichung";
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
            FormRaum formRaum = new FormRaum((Raum)listBoxRaum.SelectedItem, this);
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
    }
}
