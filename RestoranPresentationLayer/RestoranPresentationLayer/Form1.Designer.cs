namespace RestoranPresentationLayer
{
    partial class FormRestoran
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
            this.listBoxIspis = new System.Windows.Forms.ListBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIspis
            // 
            this.listBoxIspis.FormattingEnabled = true;
            this.listBoxIspis.ItemHeight = 20;
            this.listBoxIspis.Location = new System.Drawing.Point(13, 214);
            this.listBoxIspis.Name = "listBoxIspis";
            this.listBoxIspis.Size = new System.Drawing.Size(775, 204);
            this.listBoxIspis.TabIndex = 0;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(13, 13);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(47, 20);
            this.labelNaziv.TabIndex = 1;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(17, 61);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(41, 20);
            this.labelOpis.TabIndex = 2;
            this.labelOpis.Text = "Opis";
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(17, 113);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(47, 20);
            this.labelCena.TabIndex = 3;
            this.labelCena.Text = "Cena";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(112, 13);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(100, 26);
            this.textBoxNaziv.TabIndex = 4;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(112, 70);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(100, 26);
            this.textBoxOpis.TabIndex = 5;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(112, 113);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(100, 26);
            this.textBoxCena.TabIndex = 6;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(97, 159);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(101, 41);
            this.buttonDodaj.TabIndex = 7;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(363, 18);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(34, 20);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(367, 61);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(38, 20);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Max";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(455, 18);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 26);
            this.textBoxMin.TabIndex = 10;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(455, 61);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 26);
            this.textBoxMax.TabIndex = 11;
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(414, 128);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(93, 40);
            this.buttonPretrazi.TabIndex = 12;
            this.buttonPretrazi.Text = "Pretrazi";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // FormRestoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.listBoxIspis);
            this.Name = "FormRestoran";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.FormRestoran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIspis;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Button buttonPretrazi;
    }
}

