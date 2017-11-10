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

        private void buttonGeboedeArbeit_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTypRaum_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRaum.Items.Clear();
            String typ = (String)comboBoxTypRaum.SelectedItem;

            if (typ.Equals("Alle"))
            {
                foreach (Raum r in raeume)
                {
                    listBoxRaum.Items.Add(r.Bezeichung);
                }
            }

            else
            {
                foreach (Raum r in raeume)
                {

                    if (r.TypRaume.Equals(typ))
                    {
                        listBoxRaum.Items.Add(r.Bezeichung);
                    }
                }
            }
        }
    }
}
