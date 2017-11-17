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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRaumNutzungsart = new System.Windows.Forms.ComboBox();
            this.buttonAenderungsSpeichern = new System.Windows.Forms.Button();
            this.textBoxLoeschmeiiteleinheiten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.buttonFeuerloescherDetails = new System.Windows.Forms.Button();
            this.buttonFeuerloescherloeschen = new System.Windows.Forms.Button();
            this.buttonNeuerFeuerloescherhinzufuegen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarBrandschutzplanung = new System.Windows.Forms.ProgressBar();
            this.buttonabbrechen = new System.Windows.Forms.Button();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.textBoxInfoBrandschutz = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Location = new System.Drawing.Point(16, 16);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(69, 13);
            this.labelBezeichnung.TabIndex = 0;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // textBoxRaumBezeichnung
            // 
            this.textBoxRaumBezeichnung.Location = new System.Drawing.Point(148, 12);
            this.textBoxRaumBezeichnung.Name = "textBoxRaumBezeichnung";
            this.textBoxRaumBezeichnung.Size = new System.Drawing.Size(99, 20);
            this.textBoxRaumBezeichnung.TabIndex = 1;
            this.textBoxRaumBezeichnung.TextChanged += new System.EventHandler(this.textBoxRaumBezeichnung_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raumflaeche";
            // 
            // textBoxRaumFlaeche
            // 
            this.textBoxRaumFlaeche.Location = new System.Drawing.Point(148, 38);
            this.textBoxRaumFlaeche.Name = "textBoxRaumFlaeche";
            this.textBoxRaumFlaeche.Size = new System.Drawing.Size(99, 20);
            this.textBoxRaumFlaeche.TabIndex = 4;
            this.textBoxRaumFlaeche.TextChanged += new System.EventHandler(this.textBoxRaumFlaeche_TextChanged);
            this.textBoxRaumFlaeche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRaumFlaeche_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
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
            this.comboBoxRaumNutzungsart.Location = new System.Drawing.Point(148, 90);
            this.comboBoxRaumNutzungsart.Name = "comboBoxRaumNutzungsart";
            this.comboBoxRaumNutzungsart.Size = new System.Drawing.Size(99, 21);
            this.comboBoxRaumNutzungsart.TabIndex = 9;
            // 
            // buttonAenderungsSpeichern
            // 
            this.buttonAenderungsSpeichern.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAenderungsSpeichern.Location = new System.Drawing.Point(631, 12);
            this.buttonAenderungsSpeichern.Name = "buttonAenderungsSpeichern";
            this.buttonAenderungsSpeichern.Size = new System.Drawing.Size(114, 28);
            this.buttonAenderungsSpeichern.TabIndex = 10;
            this.buttonAenderungsSpeichern.Text = "Änderung speichern";
            this.buttonAenderungsSpeichern.UseVisualStyleBackColor = false;
            this.buttonAenderungsSpeichern.Click += new System.EventHandler(this.buttonAenderungsSpeichern_Click);
            // 
            // textBoxLoeschmeiiteleinheiten
            // 
            this.textBoxLoeschmeiiteleinheiten.Location = new System.Drawing.Point(148, 64);
            this.textBoxLoeschmeiiteleinheiten.Name = "textBoxLoeschmeiiteleinheiten";
            this.textBoxLoeschmeiiteleinheiten.ReadOnly = true;
            this.textBoxLoeschmeiiteleinheiten.Size = new System.Drawing.Size(99, 20);
            this.textBoxLoeschmeiiteleinheiten.TabIndex = 12;
            this.textBoxLoeschmeiiteleinheiten.TextChanged += new System.EventHandler(this.textBoxLoeschmeiiteleinheiten_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Löschmitteleinheit Raum";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.11675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.88325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(253, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 268);
            this.tableLayoutPanel1.TabIndex = 19;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // textBoxGesamptpreis
            // 
            this.textBoxGesamptpreis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxGesamptpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGesamptpreis.ForeColor = System.Drawing.Color.Black;
            this.textBoxGesamptpreis.Location = new System.Drawing.Point(631, 251);
            this.textBoxGesamptpreis.Name = "textBoxGesamptpreis";
            this.textBoxGesamptpreis.ReadOnly = true;
            this.textBoxGesamptpreis.Size = new System.Drawing.Size(114, 23);
            this.textBoxGesamptpreis.TabIndex = 21;
            this.textBoxGesamptpreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGesamptpreis.TextChanged += new System.EventHandler(this.textBoxGesamptpreis_TextChanged);
            // 
            // textBoxAnzahlSumme
            // 
            this.textBoxAnzahlSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnzahlSumme.Location = new System.Drawing.Point(631, 223);
            this.textBoxAnzahlSumme.Name = "textBoxAnzahlSumme";
            this.textBoxAnzahlSumme.ReadOnly = true;
            this.textBoxAnzahlSumme.Size = new System.Drawing.Size(114, 22);
            this.textBoxAnzahlSumme.TabIndex = 22;
            this.textBoxAnzahlSumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLESumme
            // 
            this.textBoxLESumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLESumme.Location = new System.Drawing.Point(631, 195);
            this.textBoxLESumme.Name = "textBoxLESumme";
            this.textBoxLESumme.ReadOnly = true;
            this.textBoxLESumme.Size = new System.Drawing.Size(114, 22);
            this.textBoxLESumme.TabIndex = 23;
            this.textBoxLESumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxLESumme.TextChanged += new System.EventHandler(this.textBoxLESumme_TextChanged);
            // 
            // listBoxPreisSummaFeuerloscher
            // 
            this.listBoxPreisSummaFeuerloscher.FormattingEnabled = true;
            this.listBoxPreisSummaFeuerloscher.Location = new System.Drawing.Point(301, 37);
            this.listBoxPreisSummaFeuerloscher.Name = "listBoxPreisSummaFeuerloscher";
            this.listBoxPreisSummaFeuerloscher.Size = new System.Drawing.Size(65, 225);
            this.listBoxPreisSummaFeuerloscher.TabIndex = 20;
            this.listBoxPreisSummaFeuerloscher.SelectedIndexChanged += new System.EventHandler(this.listBoxPreisSummaFeuerloscher_SelectedIndexChanged);
            this.listBoxPreisSummaFeuerloscher.DoubleClick += new System.EventHandler(this.buttonFeuerloescherDetails_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(301, 0);
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
            this.label2.Location = new System.Drawing.Point(176, 0);
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
            this.label9.Size = new System.Drawing.Size(96, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Löschmitteleinheit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(224, 0);
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
            this.listBoxFeuerlocher.Size = new System.Drawing.Size(65, 225);
            this.listBoxFeuerlocher.TabIndex = 4;
            this.listBoxFeuerlocher.SelectedIndexChanged += new System.EventHandler(this.listBoxFeuerlocher_SelectedIndexChanged);
            this.listBoxFeuerlocher.DoubleClick += new System.EventHandler(this.buttonFeuerloescherDetails_Click);
            // 
            // listBoxLE
            // 
            this.listBoxLE.FormattingEnabled = true;
            this.listBoxLE.Location = new System.Drawing.Point(74, 37);
            this.listBoxLE.Name = "listBoxLE";
            this.listBoxLE.Size = new System.Drawing.Size(96, 225);
            this.listBoxLE.TabIndex = 5;
            this.listBoxLE.SelectedIndexChanged += new System.EventHandler(this.listBoxLE_SelectedIndexChanged);
            this.listBoxLE.DoubleClick += new System.EventHandler(this.buttonFeuerloescherDetails_Click);
            // 
            // listBoxCountFeuerloescher
            // 
            this.listBoxCountFeuerloescher.FormattingEnabled = true;
            this.listBoxCountFeuerloescher.Location = new System.Drawing.Point(176, 37);
            this.listBoxCountFeuerloescher.Name = "listBoxCountFeuerloescher";
            this.listBoxCountFeuerloescher.Size = new System.Drawing.Size(42, 225);
            this.listBoxCountFeuerloescher.TabIndex = 6;
            this.listBoxCountFeuerloescher.SelectedIndexChanged += new System.EventHandler(this.listBoxCountFeuerloescher_SelectedIndexChanged);
            this.listBoxCountFeuerloescher.DoubleClick += new System.EventHandler(this.buttonFeuerloescherDetails_Click);
            // 
            // listBoxPreisFeuerloescher
            // 
            this.listBoxPreisFeuerloescher.FormattingEnabled = true;
            this.listBoxPreisFeuerloescher.Location = new System.Drawing.Point(224, 37);
            this.listBoxPreisFeuerloescher.Name = "listBoxPreisFeuerloescher";
            this.listBoxPreisFeuerloescher.Size = new System.Drawing.Size(71, 225);
            this.listBoxPreisFeuerloescher.TabIndex = 7;
            this.listBoxPreisFeuerloescher.SelectedIndexChanged += new System.EventHandler(this.listBoxPreisFeuerloescher_SelectedIndexChanged);
            this.listBoxPreisFeuerloescher.DoubleClick += new System.EventHandler(this.buttonFeuerloescherDetails_Click);
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
            // buttonFeuerloescherDetails
            // 
            this.buttonFeuerloescherDetails.BackColor = System.Drawing.Color.Gold;
            this.buttonFeuerloescherDetails.Location = new System.Drawing.Point(631, 46);
            this.buttonFeuerloescherDetails.Name = "buttonFeuerloescherDetails";
            this.buttonFeuerloescherDetails.Size = new System.Drawing.Size(114, 30);
            this.buttonFeuerloescherDetails.TabIndex = 20;
            this.buttonFeuerloescherDetails.Text = "Details Feuerlöscher";
            this.buttonFeuerloescherDetails.UseVisualStyleBackColor = false;
            this.buttonFeuerloescherDetails.Click += new System.EventHandler(this.buttonFeuerloescherDetails_Click);
            // 
            // buttonFeuerloescherloeschen
            // 
            this.buttonFeuerloescherloeschen.BackColor = System.Drawing.Color.LightCoral;
            this.buttonFeuerloescherloeschen.Location = new System.Drawing.Point(631, 118);
            this.buttonFeuerloescherloeschen.Name = "buttonFeuerloescherloeschen";
            this.buttonFeuerloescherloeschen.Size = new System.Drawing.Size(114, 30);
            this.buttonFeuerloescherloeschen.TabIndex = 21;
            this.buttonFeuerloescherloeschen.Text = "Löschen";
            this.buttonFeuerloescherloeschen.UseVisualStyleBackColor = false;
            this.buttonFeuerloescherloeschen.Click += new System.EventHandler(this.buttonFeuerloescherloeschen_Click);
            // 
            // buttonNeuerFeuerloescherhinzufuegen
            // 
            this.buttonNeuerFeuerloescherhinzufuegen.BackColor = System.Drawing.Color.LightGreen;
            this.buttonNeuerFeuerloescherhinzufuegen.Location = new System.Drawing.Point(631, 82);
            this.buttonNeuerFeuerloescherhinzufuegen.Name = "buttonNeuerFeuerloescherhinzufuegen";
            this.buttonNeuerFeuerloescherhinzufuegen.Size = new System.Drawing.Size(114, 30);
            this.buttonNeuerFeuerloescherhinzufuegen.TabIndex = 22;
            this.buttonNeuerFeuerloescherhinzufuegen.Text = "Neuen hinzufügen";
            this.buttonNeuerFeuerloescherhinzufuegen.UseVisualStyleBackColor = false;
            this.buttonNeuerFeuerloescherhinzufuegen.Click += new System.EventHandler(this.buttonNeuerFeuerloescherhinzufuegen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "- Die Löschmitteleinheit aller Feuerlöschern";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "- Der Anzahl aller Feuerlöschern";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "- Gesamptpreis Brandschutzplanung";
            // 
            // progressBarBrandschutzplanung
            // 
            this.progressBarBrandschutzplanung.Location = new System.Drawing.Point(256, 286);
            this.progressBarBrandschutzplanung.Name = "progressBarBrandschutzplanung";
            this.progressBarBrandschutzplanung.Size = new System.Drawing.Size(363, 23);
            this.progressBarBrandschutzplanung.TabIndex = 26;
            // 
            // buttonabbrechen
            // 
            this.buttonabbrechen.Location = new System.Drawing.Point(631, 281);
            this.buttonabbrechen.Name = "buttonabbrechen";
            this.buttonabbrechen.Size = new System.Drawing.Size(114, 28);
            this.buttonabbrechen.TabIndex = 42;
            this.buttonabbrechen.Text = "Schliessen";
            this.buttonabbrechen.UseVisualStyleBackColor = true;
            this.buttonabbrechen.Click += new System.EventHandler(this.buttonabbrechen_Click);
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.labelProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgressBar.Location = new System.Drawing.Point(253, 312);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(366, 23);
            this.labelProgressBar.TabIndex = 43;
            this.labelProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInfoBrandschutz
            // 
            this.textBoxInfoBrandschutz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfoBrandschutz.Location = new System.Drawing.Point(754, 13);
            this.textBoxInfoBrandschutz.Multiline = true;
            this.textBoxInfoBrandschutz.Name = "textBoxInfoBrandschutz";
            this.textBoxInfoBrandschutz.Size = new System.Drawing.Size(263, 184);
            this.textBoxInfoBrandschutz.TabIndex = 44;
            // 
            // FormRaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 379);
            this.Controls.Add(this.textBoxInfoBrandschutz);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.buttonabbrechen);
            this.Controls.Add(this.progressBarBrandschutzplanung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGesamptpreis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNeuerFeuerloescherhinzufuegen);
            this.Controls.Add(this.textBoxLESumme);
            this.Controls.Add(this.textBoxAnzahlSumme);
            this.Controls.Add(this.buttonFeuerloescherloeschen);
            this.Controls.Add(this.buttonFeuerloescherDetails);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxLoeschmeiiteleinheiten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAenderungsSpeichern);
            this.Controls.Add(this.comboBoxRaumNutzungsart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRaumFlaeche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRaumBezeichnung);
            this.Controls.Add(this.labelBezeichnung);
            this.Name = "FormRaum";
            this.Text = "Brandschutyplanung";
            this.Load += new System.EventHandler(this.FormRaum_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.TextBox textBoxRaumBezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRaumFlaeche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRaumNutzungsart;
        private System.Windows.Forms.Button buttonAenderungsSpeichern;
        private System.Windows.Forms.TextBox textBoxLoeschmeiiteleinheiten;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TextBox textBoxGesamptpreis;
        private System.Windows.Forms.TextBox textBoxAnzahlSumme;
        private System.Windows.Forms.TextBox textBoxLESumme;
        private System.Windows.Forms.Button buttonFeuerloescherDetails;
        private System.Windows.Forms.Button buttonFeuerloescherloeschen;
        private System.Windows.Forms.Button buttonNeuerFeuerloescherhinzufuegen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarBrandschutzplanung;
        private System.Windows.Forms.Button buttonabbrechen;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.TextBox textBoxInfoBrandschutz;
    }
}