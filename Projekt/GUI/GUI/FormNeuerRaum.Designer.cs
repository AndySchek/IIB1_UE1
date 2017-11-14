namespace GUI
{
    partial class FormNeuerRaum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxRaumNutzungsart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRaumFlaeche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRaumBezeichnung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNeuerRaum = new System.Windows.Forms.Button();
            this.comboBoxLoeschvermoegen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRaumNutzungsart
            // 
            this.comboBoxRaumNutzungsart.FormattingEnabled = true;
            this.comboBoxRaumNutzungsart.Items.AddRange(new object[] {
            "Wohnung",
            "Büroarbeit",
            "Bildung"});
            this.comboBoxRaumNutzungsart.Location = new System.Drawing.Point(138, 6);
            this.comboBoxRaumNutzungsart.Name = "comboBoxRaumNutzungsart";
            this.comboBoxRaumNutzungsart.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRaumNutzungsart.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nutzungart";
            // 
            // textBoxRaumFlaeche
            // 
            this.textBoxRaumFlaeche.Location = new System.Drawing.Point(138, 59);
            this.textBoxRaumFlaeche.Name = "textBoxRaumFlaeche";
            this.textBoxRaumFlaeche.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumFlaeche.TabIndex = 13;
            this.textBoxRaumFlaeche.TextChanged += new System.EventHandler(this.textBoxRaumFlaeche_TextChanged);
            this.textBoxRaumFlaeche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRaumFlaeche_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Raumflaeche";
            // 
            // textBoxRaumBezeichnung
            // 
            this.textBoxRaumBezeichnung.Location = new System.Drawing.Point(138, 33);
            this.textBoxRaumBezeichnung.Name = "textBoxRaumBezeichnung";
            this.textBoxRaumBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBezeichnung.TabIndex = 11;
            this.textBoxRaumBezeichnung.TextChanged += new System.EventHandler(this.textBoxRaumBezeichnung_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bezeichnung";
            // 
            // buttonNeuerRaum
            // 
            this.buttonNeuerRaum.Location = new System.Drawing.Point(12, 120);
            this.buttonNeuerRaum.Name = "buttonNeuerRaum";
            this.buttonNeuerRaum.Size = new System.Drawing.Size(223, 23);
            this.buttonNeuerRaum.TabIndex = 16;
            this.buttonNeuerRaum.Text = "Neuer Raum erstellen";
            this.buttonNeuerRaum.UseVisualStyleBackColor = true;
            this.buttonNeuerRaum.Click += new System.EventHandler(this.buttonNeuerRaum_Click);
            // 
            // comboBoxLoeschvermoegen
            // 
            this.comboBoxLoeschvermoegen.FormattingEnabled = true;
            this.comboBoxLoeschvermoegen.Location = new System.Drawing.Point(138, 85);
            this.comboBoxLoeschvermoegen.Name = "comboBoxLoeschvermoegen";
            this.comboBoxLoeschvermoegen.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLoeschvermoegen.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Löschvermögen";
            // 
            // FormNeuerRaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxLoeschvermoegen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonNeuerRaum);
            this.Controls.Add(this.comboBoxRaumNutzungsart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRaumFlaeche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRaumBezeichnung);
            this.Controls.Add(this.label2);
            this.Name = "FormNeuerRaum";
            this.Text = "Neuer Raum erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxRaumNutzungsart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRaumFlaeche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRaumBezeichnung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNeuerRaum;
        private System.Windows.Forms.ComboBox comboBoxLoeschvermoegen;
        private System.Windows.Forms.Label label6;
    }
}