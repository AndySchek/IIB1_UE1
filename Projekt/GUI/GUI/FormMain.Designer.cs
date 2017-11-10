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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRaum = new System.Windows.Forms.ListBox();
            this.buttonRaumDetail = new System.Windows.Forms.Button();
            this.comboBoxTypRaum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bitte wählen Sie einen Raum";
            // 
            // listBoxRaum
            // 
            this.listBoxRaum.FormattingEnabled = true;
            this.listBoxRaum.Location = new System.Drawing.Point(12, 64);
            this.listBoxRaum.Name = "listBoxRaum";
            this.listBoxRaum.Size = new System.Drawing.Size(227, 290);
            this.listBoxRaum.TabIndex = 6;
            // 
            // buttonRaumDetail
            // 
            this.buttonRaumDetail.Location = new System.Drawing.Point(245, 35);
            this.buttonRaumDetail.Name = "buttonRaumDetail";
            this.buttonRaumDetail.Size = new System.Drawing.Size(119, 23);
            this.buttonRaumDetail.TabIndex = 7;
            this.buttonRaumDetail.Text = "Details";
            this.buttonRaumDetail.UseVisualStyleBackColor = true;
            this.buttonRaumDetail.Click += new System.EventHandler(this.buttonRaumDetail_Click);
            // 
            // comboBoxTypRaum
            // 
            this.comboBoxTypRaum.FormattingEnabled = true;
            this.comboBoxTypRaum.Location = new System.Drawing.Point(12, 37);
            this.comboBoxTypRaum.Name = "comboBoxTypRaum";
            this.comboBoxTypRaum.Size = new System.Drawing.Size(227, 21);
            this.comboBoxTypRaum.TabIndex = 8;
            this.comboBoxTypRaum.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypRaum_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 365);
            this.Controls.Add(this.comboBoxTypRaum);
            this.Controls.Add(this.buttonRaumDetail);
            this.Controls.Add(this.listBoxRaum);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Willcommen bei der Brandschutzplanung";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRaum;
        private System.Windows.Forms.Button buttonRaumDetail;
        private System.Windows.Forms.ComboBox comboBoxTypRaum;
    }
}

