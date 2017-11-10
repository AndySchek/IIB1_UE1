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
            this.textBoxRaumBezeichnung.Location = new System.Drawing.Point(103, 27);
            this.textBoxRaumBezeichnung.Name = "textBoxRaumBezeichnung";
            this.textBoxRaumBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBezeichnung.TabIndex = 1;
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
            this.textBoxRaumFlaeche.Location = new System.Drawing.Point(103, 53);
            this.textBoxRaumFlaeche.Name = "textBoxRaumFlaeche";
            this.textBoxRaumFlaeche.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumFlaeche.TabIndex = 4;
            // 
            // textBoxRaumBrandgefahr
            // 
            this.textBoxRaumBrandgefahr.Location = new System.Drawing.Point(103, 79);
            this.textBoxRaumBrandgefahr.Name = "textBoxRaumBrandgefahr";
            this.textBoxRaumBrandgefahr.ReadOnly = true;
            this.textBoxRaumBrandgefahr.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBrandgefahr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brandlast";
            // 
            // textBoxRaumBrandlast
            // 
            this.textBoxRaumBrandlast.Location = new System.Drawing.Point(103, 140);
            this.textBoxRaumBrandlast.Name = "textBoxRaumBrandlast";
            this.textBoxRaumBrandlast.ReadOnly = true;
            this.textBoxRaumBrandlast.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBrandlast.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
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
            this.comboBoxRaumNutzungsart.Location = new System.Drawing.Point(103, 105);
            this.comboBoxRaumNutzungsart.Name = "comboBoxRaumNutzungsart";
            this.comboBoxRaumNutzungsart.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRaumNutzungsart.TabIndex = 9;
            // 
            // FormRaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 363);
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
    }
}