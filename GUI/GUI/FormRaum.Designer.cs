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
            this.textBoxRaumFlaeche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRaumBrandlast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRaumNutzungsart = new System.Windows.Forms.ComboBox();
            this.buttonAenderungsSpeichern = new System.Windows.Forms.Button();
            this.textBoxLoeschmeiiteleinheiten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLoeschvermoegen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCountFeuerloescher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxGesamptpreis = new System.Windows.Forms.TextBox();
            this.textBoxAnzahlSumme = new System.Windows.Forms.TextBox();
            this.textBoxLESumme = new System.Windows.Forms.TextBox();
            this.listBoxPreisSummaFeuerloscher = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxFeuerlocher = new System.Windows.Forms.ListBox();
            this.listBoxLE = new System.Windows.Forms.ListBox();
            this.listBoxCountFeuerloescher = new System.Windows.Forms.ListBox();
            this.listBoxPreisFeuerloescher = new System.Windows.Forms.ListBox();
            this.Feuerlocher = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Location = new System.Drawing.Point(15, 30);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(69, 13);
            this.labelBezeichnung.TabIndex = 0;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // textBoxRaumBezeichnung
            // 
            this.textBoxRaumBezeichnung.Location = new System.Drawing.Point(131, 22);
            this.textBoxRaumBezeichnung.Name = "textBoxRaumBezeichnung";
            this.textBoxRaumBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBezeichnung.TabIndex = 1;
            this.textBoxRaumBezeichnung.TextChanged += new System.EventHandler(this.textBoxRaumBezeichnung_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raumflaeche";
            // 
            // textBoxRaumFlaeche
            // 
            this.textBoxRaumFlaeche.Location = new System.Drawing.Point(131, 48);
            this.textBoxRaumFlaeche.Name = "textBoxRaumFlaeche";
            this.textBoxRaumFlaeche.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumFlaeche.TabIndex = 4;
            this.textBoxRaumFlaeche.TextChanged += new System.EventHandler(this.textBoxRaumFlaeche_TextChanged);
            this.textBoxRaumFlaeche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRaumFlaeche_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brandlast";
            // 
            // textBoxRaumBrandlast
            // 
            this.textBoxRaumBrandlast.Location = new System.Drawing.Point(630, 228);
            this.textBoxRaumBrandlast.Name = "textBoxRaumBrandlast";
            this.textBoxRaumBrandlast.ReadOnly = true;
            this.textBoxRaumBrandlast.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaumBrandlast.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nutzungart";
            // 
            // comboBoxRaumNutzungsart
            // 
            this.comboBoxRaumNutzungsart.FormattingEnabled = true;
            this.comboBoxRaumNutzungsart.Items.AddRange(new object[] {
            "Büro",
            "Flur",
            "Seminarraum",
            "Sanitärraum"});
            this.comboBoxRaumNutzungsart.Location = new System.Drawing.Point(131, 74);
            this.comboBoxRaumNutzungsart.Name = "comboBoxRaumNutzungsart";
            this.comboBoxRaumNutzungsart.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRaumNutzungsart.TabIndex = 9;
            // 
            // buttonAenderungsSpeichern
            // 
            this.buttonAenderungsSpeichern.Location = new System.Drawing.Point(15, 377);
            this.buttonAenderungsSpeichern.Name = "buttonAenderungsSpeichern";
            this.buttonAenderungsSpeichern.Size = new System.Drawing.Size(453, 23);
            this.buttonAenderungsSpeichern.TabIndex = 10;
            this.buttonAenderungsSpeichern.Text = "Änderung speichern";
            this.buttonAenderungsSpeichern.UseVisualStyleBackColor = true;
            this.buttonAenderungsSpeichern.Click += new System.EventHandler(this.buttonAenderungsSpeichern_Click);
            // 
            // textBoxLoeschmeiiteleinheiten
            // 
            this.textBoxLoeschmeiiteleinheiten.Location = new System.Drawing.Point(237, 48);
            this.textBoxLoeschmeiiteleinheiten.Name = "textBoxLoeschmeiiteleinheiten";
            this.textBoxLoeschmeiiteleinheiten.ReadOnly = true;
            this.textBoxLoeschmeiiteleinheiten.Size = new System.Drawing.Size(122, 20);
            this.textBoxLoeschmeiiteleinheiten.TabIndex = 12;
            this.textBoxLoeschmeiiteleinheiten.TextChanged += new System.EventHandler(this.textBoxLoeschmeiiteleinheiten_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Löschmitteleinheiten";
            // 
            // comboBoxLoeschvermoegen
            // 
            this.comboBoxLoeschvermoegen.FormattingEnabled = true;
            this.comboBoxLoeschvermoegen.Location = new System.Drawing.Point(668, 137);
            this.comboBoxLoeschvermoegen.Name = "comboBoxLoeschvermoegen";
            this.comboBoxLoeschvermoegen.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLoeschvermoegen.TabIndex = 14;
            this.comboBoxLoeschvermoegen.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoeschvermoegen_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Löschvermögen";
            // 
            // textBoxCountFeuerloescher
            // 
            this.textBoxCountFeuerloescher.Location = new System.Drawing.Point(722, 263);
            this.textBoxCountFeuerloescher.Name = "textBoxCountFeuerloescher";
            this.textBoxCountFeuerloescher.ReadOnly = true;
            this.textBoxCountFeuerloescher.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountFeuerloescher.TabIndex = 16;
            this.textBoxCountFeuerloescher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(515, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "\r\nFeuerlöscher dieser Bauart für die Grundausstattung erforderlich. \r\n\r\n";
            // 
            // textBoxLE
            // 
            this.textBoxLE.Location = new System.Drawing.Point(748, 190);
            this.textBoxLE.Name = "textBoxLE";
            this.textBoxLE.ReadOnly = true;
            this.textBoxLE.Size = new System.Drawing.Size(61, 20);
            this.textBoxLE.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "LE";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.11675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.88325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGesamptpreis, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAnzahlSumme, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLESumme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPreisSummaFeuerloscher, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxFeuerlocher, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxLE, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxCountFeuerloescher, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPreisFeuerloescher, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Feuerlocher, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 230);
            this.tableLayoutPanel1.TabIndex = 19;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 207);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(65, 20);
            this.textBox5.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBoxGesamptpreis
            // 
            this.textBoxGesamptpreis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxGesamptpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGesamptpreis.ForeColor = System.Drawing.Color.Black;
            this.textBoxGesamptpreis.Location = new System.Drawing.Point(302, 207);
            this.textBoxGesamptpreis.Name = "textBoxGesamptpreis";
            this.textBoxGesamptpreis.ReadOnly = true;
            this.textBoxGesamptpreis.Size = new System.Drawing.Size(65, 23);
            this.textBoxGesamptpreis.TabIndex = 21;
            // 
            // textBoxAnzahlSumme
            // 
            this.textBoxAnzahlSumme.Location = new System.Drawing.Point(177, 207);
            this.textBoxAnzahlSumme.Name = "textBoxAnzahlSumme";
            this.textBoxAnzahlSumme.ReadOnly = true;
            this.textBoxAnzahlSumme.Size = new System.Drawing.Size(42, 20);
            this.textBoxAnzahlSumme.TabIndex = 22;
            // 
            // textBoxLESumme
            // 
            this.textBoxLESumme.Location = new System.Drawing.Point(74, 207);
            this.textBoxLESumme.Name = "textBoxLESumme";
            this.textBoxLESumme.ReadOnly = true;
            this.textBoxLESumme.Size = new System.Drawing.Size(97, 20);
            this.textBoxLESumme.TabIndex = 23;
            // 
            // listBoxPreisSummaFeuerloscher
            // 
            this.listBoxPreisSummaFeuerloscher.FormattingEnabled = true;
            this.listBoxPreisSummaFeuerloscher.Location = new System.Drawing.Point(302, 37);
            this.listBoxPreisSummaFeuerloscher.Name = "listBoxPreisSummaFeuerloscher";
            this.listBoxPreisSummaFeuerloscher.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxPreisSummaFeuerloscher.Size = new System.Drawing.Size(65, 160);
            this.listBoxPreisSummaFeuerloscher.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(302, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Summe (€)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(177, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anzahl";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(74, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Löschmitteleinheit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(225, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Preis für 1 (€)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxFeuerlocher
            // 
            this.listBoxFeuerlocher.FormattingEnabled = true;
            this.listBoxFeuerlocher.Location = new System.Drawing.Point(3, 37);
            this.listBoxFeuerlocher.Name = "listBoxFeuerlocher";
            this.listBoxFeuerlocher.Size = new System.Drawing.Size(65, 160);
            this.listBoxFeuerlocher.TabIndex = 4;
            // 
            // listBoxLE
            // 
            this.listBoxLE.FormattingEnabled = true;
            this.listBoxLE.Location = new System.Drawing.Point(74, 37);
            this.listBoxLE.Name = "listBoxLE";
            this.listBoxLE.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLE.Size = new System.Drawing.Size(97, 160);
            this.listBoxLE.Sorted = true;
            this.listBoxLE.TabIndex = 5;
            // 
            // listBoxCountFeuerloescher
            // 
            this.listBoxCountFeuerloescher.FormattingEnabled = true;
            this.listBoxCountFeuerloescher.Location = new System.Drawing.Point(177, 37);
            this.listBoxCountFeuerloescher.Name = "listBoxCountFeuerloescher";
            this.listBoxCountFeuerloescher.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxCountFeuerloescher.Size = new System.Drawing.Size(42, 160);
            this.listBoxCountFeuerloescher.TabIndex = 6;
            // 
            // listBoxPreisFeuerloescher
            // 
            this.listBoxPreisFeuerloescher.FormattingEnabled = true;
            this.listBoxPreisFeuerloescher.Location = new System.Drawing.Point(225, 37);
            this.listBoxPreisFeuerloescher.Name = "listBoxPreisFeuerloescher";
            this.listBoxPreisFeuerloescher.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxPreisFeuerloescher.Size = new System.Drawing.Size(71, 160);
            this.listBoxPreisFeuerloescher.TabIndex = 7;
            // 
            // Feuerlocher
            // 
            this.Feuerlocher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Feuerlocher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Feuerlocher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Feuerlocher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Feuerlocher.Location = new System.Drawing.Point(3, 0);
            this.Feuerlocher.Name = "Feuerlocher";
            this.Feuerlocher.Size = new System.Drawing.Size(65, 34);
            this.Feuerlocher.TabIndex = 0;
            this.Feuerlocher.Text = "Feuerlocher";
            this.Feuerlocher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLE);
            this.Controls.Add(this.textBoxCountFeuerloescher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxLoeschvermoegen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLoeschmeiiteleinheiten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAenderungsSpeichern);
            this.Controls.Add(this.comboBoxRaumNutzungsart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRaumBrandlast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRaumFlaeche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRaumBezeichnung);
            this.Controls.Add(this.labelBezeichnung);
            this.Name = "FormRaum";
            this.Text = "FormRaum";
            this.Load += new System.EventHandler(this.FormRaum_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.TextBox textBoxRaumBezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRaumFlaeche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRaumBrandlast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRaumNutzungsart;
        private System.Windows.Forms.Button buttonAenderungsSpeichern;
        private System.Windows.Forms.TextBox textBoxLoeschmeiiteleinheiten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLoeschvermoegen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCountFeuerloescher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Feuerlocher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxFeuerlocher;
        private System.Windows.Forms.ListBox listBoxLE;
        private System.Windows.Forms.ListBox listBoxCountFeuerloescher;
        private System.Windows.Forms.ListBox listBoxPreisFeuerloescher;
        private System.Windows.Forms.ListBox listBoxPreisSummaFeuerloscher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxGesamptpreis;
        private System.Windows.Forms.TextBox textBoxAnzahlSumme;
        private System.Windows.Forms.TextBox textBoxLESumme;
    }
}