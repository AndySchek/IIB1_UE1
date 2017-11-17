namespace GUI
{
    partial class FormNeuerFeuerloescher
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
            this.comboBoxBezeichnungFeuerloescher = new System.Windows.Forms.ComboBox();
            this.labelAnzahlFeuerloescher = new System.Windows.Forms.Label();
            this.buttonNeuerFeuerloescherSpeichern = new System.Windows.Forms.Button();
            this.textBoxGesamptpreisFeuerloscher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLEFeuerloescher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarAnzahlFeuerloescher = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonabbrechen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnzahlFeuerloescher)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBezeichnungFeuerloescher
            // 
            this.comboBoxBezeichnungFeuerloescher.FormattingEnabled = true;
            this.comboBoxBezeichnungFeuerloescher.Location = new System.Drawing.Point(132, 12);
            this.comboBoxBezeichnungFeuerloescher.Name = "comboBoxBezeichnungFeuerloescher";
            this.comboBoxBezeichnungFeuerloescher.Size = new System.Drawing.Size(143, 21);
            this.comboBoxBezeichnungFeuerloescher.TabIndex = 0;
            this.comboBoxBezeichnungFeuerloescher.SelectedIndexChanged += new System.EventHandler(this.comboBoxBezeichnungFeuerloescher_SelectedIndexChanged);
            // 
            // labelAnzahlFeuerloescher
            // 
            this.labelAnzahlFeuerloescher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAnzahlFeuerloescher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnzahlFeuerloescher.Location = new System.Drawing.Point(102, 43);
            this.labelAnzahlFeuerloescher.Name = "labelAnzahlFeuerloescher";
            this.labelAnzahlFeuerloescher.Size = new System.Drawing.Size(26, 22);
            this.labelAnzahlFeuerloescher.TabIndex = 40;
            this.labelAnzahlFeuerloescher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNeuerFeuerloescherSpeichern
            // 
            this.buttonNeuerFeuerloescherSpeichern.Location = new System.Drawing.Point(57, 130);
            this.buttonNeuerFeuerloescherSpeichern.Name = "buttonNeuerFeuerloescherSpeichern";
            this.buttonNeuerFeuerloescherSpeichern.Size = new System.Drawing.Size(146, 42);
            this.buttonNeuerFeuerloescherSpeichern.TabIndex = 39;
            this.buttonNeuerFeuerloescherSpeichern.Text = "Neuer Feuerlöscher hinzufügen";
            this.buttonNeuerFeuerloescherSpeichern.UseVisualStyleBackColor = true;
            this.buttonNeuerFeuerloescherSpeichern.Click += new System.EventHandler(this.buttonNeuerFeuerloescherSpeichern_Click);
            // 
            // textBoxGesamptpreisFeuerloscher
            // 
            this.textBoxGesamptpreisFeuerloscher.Location = new System.Drawing.Point(132, 104);
            this.textBoxGesamptpreisFeuerloscher.Name = "textBoxGesamptpreisFeuerloscher";
            this.textBoxGesamptpreisFeuerloscher.ReadOnly = true;
            this.textBoxGesamptpreisFeuerloscher.Size = new System.Drawing.Size(143, 20);
            this.textBoxGesamptpreisFeuerloscher.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Gesamptpreis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Anzahl";
            // 
            // textBoxLEFeuerloescher
            // 
            this.textBoxLEFeuerloescher.Location = new System.Drawing.Point(132, 78);
            this.textBoxLEFeuerloescher.Name = "textBoxLEFeuerloescher";
            this.textBoxLEFeuerloescher.ReadOnly = true;
            this.textBoxLEFeuerloescher.Size = new System.Drawing.Size(143, 20);
            this.textBoxLEFeuerloescher.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Löschmitteleinheit";
            // 
            // trackBarAnzahlFeuerloescher
            // 
            this.trackBarAnzahlFeuerloescher.Location = new System.Drawing.Point(132, 39);
            this.trackBarAnzahlFeuerloescher.Maximum = 30;
            this.trackBarAnzahlFeuerloescher.Minimum = 1;
            this.trackBarAnzahlFeuerloescher.Name = "trackBarAnzahlFeuerloescher";
            this.trackBarAnzahlFeuerloescher.Size = new System.Drawing.Size(143, 45);
            this.trackBarAnzahlFeuerloescher.TabIndex = 33;
            this.trackBarAnzahlFeuerloescher.Value = 1;
            this.trackBarAnzahlFeuerloescher.ValueChanged += new System.EventHandler(this.trackBarAnzahlFeuerloescher_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bezeichnung";
            // 
            // buttonabbrechen
            // 
            this.buttonabbrechen.Location = new System.Drawing.Point(57, 178);
            this.buttonabbrechen.Name = "buttonabbrechen";
            this.buttonabbrechen.Size = new System.Drawing.Size(146, 32);
            this.buttonabbrechen.TabIndex = 41;
            this.buttonabbrechen.Text = "Schliessen";
            this.buttonabbrechen.UseVisualStyleBackColor = true;
            this.buttonabbrechen.Click += new System.EventHandler(this.buttonabbrechen_Click);
            // 
            // FormNeuerFeuerloescher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 234);
            this.Controls.Add(this.buttonabbrechen);
            this.Controls.Add(this.labelAnzahlFeuerloescher);
            this.Controls.Add(this.buttonNeuerFeuerloescherSpeichern);
            this.Controls.Add(this.textBoxGesamptpreisFeuerloscher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLEFeuerloescher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarAnzahlFeuerloescher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBezeichnungFeuerloescher);
            this.Name = "FormNeuerFeuerloescher";
            this.Text = "FormNeuerFeuerloescher";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnzahlFeuerloescher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBezeichnungFeuerloescher;
        private System.Windows.Forms.Label labelAnzahlFeuerloescher;
        private System.Windows.Forms.Button buttonNeuerFeuerloescherSpeichern;
        private System.Windows.Forms.TextBox textBoxGesamptpreisFeuerloscher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLEFeuerloescher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarAnzahlFeuerloescher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonabbrechen;
    }
}