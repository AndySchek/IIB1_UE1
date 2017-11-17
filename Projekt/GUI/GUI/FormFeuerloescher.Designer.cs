namespace GUI
{
    partial class FormFeuerloescher
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBezeichnungFeuerloescher = new System.Windows.Forms.TextBox();
            this.trackBarAnzahlFeuerloescher = new System.Windows.Forms.TrackBar();
            this.textBoxLEFeuerloescher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGesamptpreisFeuerloscher = new System.Windows.Forms.TextBox();
            this.buttonAenderungFeuerloescherSpeichern = new System.Windows.Forms.Button();
            this.labelAnzahlFeuerloescher = new System.Windows.Forms.Label();
            this.buttonFeuerloescherloeschen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnzahlFeuerloescher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bezeichnung";
            // 
            // textBoxBezeichnungFeuerloescher
            // 
            this.textBoxBezeichnungFeuerloescher.Location = new System.Drawing.Point(168, 13);
            this.textBoxBezeichnungFeuerloescher.Name = "textBoxBezeichnungFeuerloescher";
            this.textBoxBezeichnungFeuerloescher.ReadOnly = true;
            this.textBoxBezeichnungFeuerloescher.Size = new System.Drawing.Size(115, 20);
            this.textBoxBezeichnungFeuerloescher.TabIndex = 23;
            // 
            // trackBarAnzahlFeuerloescher
            // 
            this.trackBarAnzahlFeuerloescher.Location = new System.Drawing.Point(132, 64);
            this.trackBarAnzahlFeuerloescher.Maximum = 30;
            this.trackBarAnzahlFeuerloescher.Minimum = 1;
            this.trackBarAnzahlFeuerloescher.Name = "trackBarAnzahlFeuerloescher";
            this.trackBarAnzahlFeuerloescher.Size = new System.Drawing.Size(185, 45);
            this.trackBarAnzahlFeuerloescher.TabIndex = 24;
            this.trackBarAnzahlFeuerloescher.Value = 1;
            this.trackBarAnzahlFeuerloescher.ValueChanged += new System.EventHandler(this.trackBarAnzahlFeuerloescher_ValueChanged);
            // 
            // textBoxLEFeuerloescher
            // 
            this.textBoxLEFeuerloescher.Location = new System.Drawing.Point(168, 38);
            this.textBoxLEFeuerloescher.Name = "textBoxLEFeuerloescher";
            this.textBoxLEFeuerloescher.ReadOnly = true;
            this.textBoxLEFeuerloescher.Size = new System.Drawing.Size(115, 20);
            this.textBoxLEFeuerloescher.TabIndex = 26;
            this.textBoxLEFeuerloescher.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Löschmitteleinheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Anzahl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Gesamptpreis";
            // 
            // textBoxGesamptpreisFeuerloscher
            // 
            this.textBoxGesamptpreisFeuerloscher.Location = new System.Drawing.Point(168, 112);
            this.textBoxGesamptpreisFeuerloscher.Name = "textBoxGesamptpreisFeuerloscher";
            this.textBoxGesamptpreisFeuerloscher.ReadOnly = true;
            this.textBoxGesamptpreisFeuerloscher.Size = new System.Drawing.Size(115, 20);
            this.textBoxGesamptpreisFeuerloscher.TabIndex = 29;
            // 
            // buttonAenderungFeuerloescherSpeichern
            // 
            this.buttonAenderungFeuerloescherSpeichern.Location = new System.Drawing.Point(16, 153);
            this.buttonAenderungFeuerloescherSpeichern.Name = "buttonAenderungFeuerloescherSpeichern";
            this.buttonAenderungFeuerloescherSpeichern.Size = new System.Drawing.Size(115, 23);
            this.buttonAenderungFeuerloescherSpeichern.TabIndex = 30;
            this.buttonAenderungFeuerloescherSpeichern.Text = "Änderung speichern";
            this.buttonAenderungFeuerloescherSpeichern.UseVisualStyleBackColor = true;
            this.buttonAenderungFeuerloescherSpeichern.Click += new System.EventHandler(this.buttonAenderungFeuerloescherSpeichern_Click);
            // 
            // labelAnzahlFeuerloescher
            // 
            this.labelAnzahlFeuerloescher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAnzahlFeuerloescher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnzahlFeuerloescher.Location = new System.Drawing.Point(104, 68);
            this.labelAnzahlFeuerloescher.Name = "labelAnzahlFeuerloescher";
            this.labelAnzahlFeuerloescher.Size = new System.Drawing.Size(26, 22);
            this.labelAnzahlFeuerloescher.TabIndex = 31;
            this.labelAnzahlFeuerloescher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFeuerloescherloeschen
            // 
            this.buttonFeuerloescherloeschen.Location = new System.Drawing.Point(16, 182);
            this.buttonFeuerloescherloeschen.Name = "buttonFeuerloescherloeschen";
            this.buttonFeuerloescherloeschen.Size = new System.Drawing.Size(115, 36);
            this.buttonFeuerloescherloeschen.TabIndex = 32;
            this.buttonFeuerloescherloeschen.Text = "Feuerlöscher löschen";
            this.buttonFeuerloescherloeschen.UseVisualStyleBackColor = true;
            this.buttonFeuerloescherloeschen.Click += new System.EventHandler(this.buttonFeuerloescherloeschen_Click);
            // 
            // FormFeuerloescher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 258);
            this.Controls.Add(this.buttonFeuerloescherloeschen);
            this.Controls.Add(this.labelAnzahlFeuerloescher);
            this.Controls.Add(this.buttonAenderungFeuerloescherSpeichern);
            this.Controls.Add(this.textBoxGesamptpreisFeuerloscher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLEFeuerloescher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarAnzahlFeuerloescher);
            this.Controls.Add(this.textBoxBezeichnungFeuerloescher);
            this.Controls.Add(this.label1);
            this.Name = "FormFeuerloescher";
            this.Text = "Feuerlöscher";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnzahlFeuerloescher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBezeichnungFeuerloescher;
        private System.Windows.Forms.TrackBar trackBarAnzahlFeuerloescher;
        private System.Windows.Forms.TextBox textBoxLEFeuerloescher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGesamptpreisFeuerloscher;
        private System.Windows.Forms.Button buttonAenderungFeuerloescherSpeichern;
        private System.Windows.Forms.Label labelAnzahlFeuerloescher;
        private System.Windows.Forms.Button buttonFeuerloescherloeschen;
    }
}