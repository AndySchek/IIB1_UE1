namespace GUI
{
    partial class FormRaum
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
            this.labelBezeichnung = new System.Windows.Forms.Label();
            this.textBoxRaumBezeichnung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRaumFlaeche = new System.Windows.Forms.TextBox();
            this.textBoxRaumBrandgefahr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRaumBrandlast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRaumNutzungsart = new System.Windows.Forms.ComboBox();
            this.buttonAenderungsSpeichern = new System.Windows.Forms.Button();
            this.textBoxLoeschmeiiteleinheiten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Location = new System.Drawing.Point(12, 30);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(69, 13);
            this.labelBezeichnung.TabIndex = 0;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // textBoxRaumBezeichnung
            // 
            this.textBoxRaumBezeichnung.Location = new System.Drawing.Point(130, 23);
            this.textBoxRaumBezeichnung.Name = "textBoxRaumBezeichnung";
            this.textBoxRaumBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBezeichnung.TabIndex = 1;
            this.textBoxRaumBezeichnung.TextChanged += new System.EventHandler(this.textBoxRaumBezeichnung_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raumflaeche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brandgefahr";
            // 
            // textBoxRaumFlaeche
            // 
            this.textBoxRaumFlaeche.Location = new System.Drawing.Point(130, 49);
            this.textBoxRaumFlaeche.Name = "textBoxRaumFlaeche";
            this.textBoxRaumFlaeche.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumFlaeche.TabIndex = 4;
            this.textBoxRaumFlaeche.TextChanged += new System.EventHandler(this.textBoxRaumFlaeche_TextChanged);
            this.textBoxRaumFlaeche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRaumFlaeche_KeyPress);
            // 
            // textBoxRaumBrandgefahr
            // 
            this.textBoxRaumBrandgefahr.Location = new System.Drawing.Point(130, 75);
            this.textBoxRaumBrandgefahr.Name = "textBoxRaumBrandgefahr";
            this.textBoxRaumBrandgefahr.ReadOnly = true;
            this.textBoxRaumBrandgefahr.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBrandgefahr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brandlast";
            // 
            // textBoxRaumBrandlast
            // 
            this.textBoxRaumBrandlast.Location = new System.Drawing.Point(130, 175);
            this.textBoxRaumBrandlast.Name = "textBoxRaumBrandlast";
            this.textBoxRaumBrandlast.ReadOnly = true;
            this.textBoxRaumBrandlast.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBrandlast.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nutzungart";
            // 
            // comboBoxRaumNutzungsart
            // 
            this.comboBoxRaumNutzungsart.FormattingEnabled = true;
            this.comboBoxRaumNutzungsart.Items.AddRange(new object[] {
            "Wohnung",
            "Büroarbeit",
            "Bildung"});
            this.comboBoxRaumNutzungsart.Location = new System.Drawing.Point(130, 140);
            this.comboBoxRaumNutzungsart.Name = "comboBoxRaumNutzungsart";
            this.comboBoxRaumNutzungsart.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRaumNutzungsart.TabIndex = 9;
            // 
            // buttonAenderungsSpeichern
            // 
            this.buttonAenderungsSpeichern.Location = new System.Drawing.Point(15, 228);
            this.buttonAenderungsSpeichern.Name = "buttonAenderungsSpeichern";
            this.buttonAenderungsSpeichern.Size = new System.Drawing.Size(188, 23);
            this.buttonAenderungsSpeichern.TabIndex = 10;
            this.buttonAenderungsSpeichern.Text = "Änderung speichern";
            this.buttonAenderungsSpeichern.UseVisualStyleBackColor = true;
            this.buttonAenderungsSpeichern.Click += new System.EventHandler(this.buttonAenderungsSpeichern_Click);
            // 
            // textBoxLoeschmeiiteleinheiten
            // 
            this.textBoxLoeschmeiiteleinheiten.Location = new System.Drawing.Point(130, 105);
            this.textBoxLoeschmeiiteleinheiten.Name = "textBoxLoeschmeiiteleinheiten";
            this.textBoxLoeschmeiiteleinheiten.ReadOnly = true;
            this.textBoxLoeschmeiiteleinheiten.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoeschmeiiteleinheiten.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Löschmitteleinheiten";
            // 
            // FormRaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 363);
            this.Controls.Add(this.textBoxLoeschmeiiteleinheiten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAenderungsSpeichern);
            this.Controls.Add(this.comboBoxRaumNutzungsart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRaumBrandlast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRaumBrandgefahr);
            this.Controls.Add(this.textBoxRaumFlaeche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRaumBezeichnung);
            this.Controls.Add(this.labelBezeichnung);
            this.Name = "FormRaum";
            this.Text = "FormRaum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.TextBox textBoxRaumBezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRaumFlaeche;
        private System.Windows.Forms.TextBox textBoxRaumBrandgefahr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRaumBrandlast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRaumNutzungsart;
        private System.Windows.Forms.Button buttonAenderungsSpeichern;
        private System.Windows.Forms.TextBox textBoxLoeschmeiiteleinheiten;
        private System.Windows.Forms.Label label5;
    }
}