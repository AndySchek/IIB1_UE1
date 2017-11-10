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
        private List<String> typRaum;

        public FormMain(BindingList<Raum> _raeume, List<String> _typRaum)
        {
            InitializeComponent();
            this.raeume = _raeume;
            this.typRaum = _typRaum;
            fuelleListe();
        }

        private void fuelleListe()
        {
            comboBoxTypRaum.Items.Add("Alle");
            foreach (var typ in typRaum)
            {
                comboBoxTypRaum.Items.Add(typ);
            }

            comboBoxTypRaum.SelectedIndex = 0;

            //comboBoxTypRaum.DataSource = typRaum;
            //listBoxRaum.DisplayMember = "TypRaum";

            //listBoxRaum.DataSource = raeume;
            //listBoxRaum.DisplayMember = "Bezeichung";

          
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
