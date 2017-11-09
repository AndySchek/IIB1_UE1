namespace GUI
{
    partial class FormMain
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
            this.buttonGeboedeArbeit = new System.Windows.Forms.Button();
            this.buttonGeboedeWohnung = new System.Windows.Forms.Button();
            this.buttonGeboedeBildung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGeboedeArbeit
            // 
            this.buttonGeboedeArbeit.Location = new System.Drawing.Point(110, 61);
            this.buttonGeboedeArbeit.Name = "buttonGeboedeArbeit";
            this.buttonGeboedeArbeit.Size = new System.Drawing.Size(180, 40);
            this.buttonGeboedeArbeit.TabIndex = 0;
            this.buttonGeboedeArbeit.Text = "Büro / Office";
            this.buttonGeboedeArbeit.UseVisualStyleBackColor = true;
            // 
            // buttonGeboedeWohnung
            // 
            this.buttonGeboedeWohnung.Location = new System.Drawing.Point(110, 107);
            this.buttonGeboedeWohnung.Name = "buttonGeboedeWohnung";
            this.buttonGeboedeWohnung.Size = new System.Drawing.Size(180, 40);
            this.buttonGeboedeWohnung.TabIndex = 3;
            this.buttonGeboedeWohnung.Text = "Wohnung / Haus";
            this.buttonGeboedeWohnung.UseVisualStyleBackColor = true;
            // 
            // buttonGeboedeBildung
            // 
            this.buttonGeboedeBildung.Location = new System.Drawing.Point(110, 153);
            this.buttonGeboedeBildung.Name = "buttonGeboedeBildung";
            this.buttonGeboedeBildung.Size = new System.Drawing.Size(180, 40);
            this.buttonGeboedeBildung.TabIndex = 4;
            this.buttonGeboedeBildung.Text = "Universität / Schule";
            this.buttonGeboedeBildung.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bitte wählen Sie einen Typ des Geböudes";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGeboedeBildung);
            this.Controls.Add(this.buttonGeboedeWohnung);
            this.Controls.Add(this.buttonGeboedeArbeit);
            this.Name = "FormMain";
            this.Text = "Willcommen bei der Brandschutzplanung";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGeboedeArbeit;
        private System.Windows.Forms.Button buttonGeboedeWohnung;
        private System.Windows.Forms.Button buttonGeboedeBildung;
        private System.Windows.Forms.Label label1;
    }
}

