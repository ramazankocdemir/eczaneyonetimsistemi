namespace EczaneYonetimSistemi
{
    partial class FrmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatis));
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.chkSigorta = new System.Windows.Forms.CheckBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnFiyatGor = new System.Windows.Forms.Button();
            this.lblIlacAdiBaslik = new System.Windows.Forms.Label();
            this.lblIlacAdi = new System.Windows.Forms.Label();
            this.lblFiyatBaslik = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBarkod.Location = new System.Drawing.Point(28, 60);
            this.lblBarkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(60, 18);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "Barkod:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(171, 61);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(76, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // chkSigorta
            // 
            this.chkSigorta.AutoSize = true;
            this.chkSigorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkSigorta.Location = new System.Drawing.Point(50, 152);
            this.chkSigorta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSigorta.Name = "chkSigorta";
            this.chkSigorta.Size = new System.Drawing.Size(179, 22);
            this.chkSigorta.TabIndex = 2;
            this.chkSigorta.Text = "Sigortalı Müşteri (SGK)";
            this.chkSigorta.UseVisualStyleBackColor = true;
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBul.Location = new System.Drawing.Point(31, 105);
            this.btnBul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(92, 25);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnFiyatGor
            // 
            this.btnFiyatGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFiyatGor.Location = new System.Drawing.Point(155, 105);
            this.btnFiyatGor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiyatGor.Name = "btnFiyatGor";
            this.btnFiyatGor.Size = new System.Drawing.Size(92, 25);
            this.btnFiyatGor.TabIndex = 4;
            this.btnFiyatGor.Text = "Fiyat Gör";
            this.btnFiyatGor.UseVisualStyleBackColor = true;
            this.btnFiyatGor.Click += new System.EventHandler(this.btnFiyatGor_Click);
            // 
            // lblIlacAdiBaslik
            // 
            this.lblIlacAdiBaslik.AutoSize = true;
            this.lblIlacAdiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIlacAdiBaslik.Location = new System.Drawing.Point(28, 195);
            this.lblIlacAdiBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIlacAdiBaslik.Name = "lblIlacAdiBaslik";
            this.lblIlacAdiBaslik.Size = new System.Drawing.Size(34, 18);
            this.lblIlacAdiBaslik.TabIndex = 5;
            this.lblIlacAdiBaslik.Text = "İlaç:";
            // 
            // lblIlacAdi
            // 
            this.lblIlacAdi.AutoSize = true;
            this.lblIlacAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIlacAdi.Location = new System.Drawing.Point(185, 195);
            this.lblIlacAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIlacAdi.Name = "lblIlacAdi";
            this.lblIlacAdi.Size = new System.Drawing.Size(13, 18);
            this.lblIlacAdi.TabIndex = 6;
            this.lblIlacAdi.Text = "-";
            // 
            // lblFiyatBaslik
            // 
            this.lblFiyatBaslik.AutoSize = true;
            this.lblFiyatBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiyatBaslik.Location = new System.Drawing.Point(28, 236);
            this.lblFiyatBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiyatBaslik.Name = "lblFiyatBaslik";
            this.lblFiyatBaslik.Size = new System.Drawing.Size(81, 18);
            this.lblFiyatBaslik.TabIndex = 7;
            this.lblFiyatBaslik.Text = "Birim Fiyat:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(185, 241);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(28, 13);
            this.lblTutar.TabIndex = 8;
            this.lblTutar.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(28, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adet :";
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudAdet.Location = new System.Drawing.Point(155, 290);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(90, 24);
            this.nudAdet.TabIndex = 10;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSatisYap.Location = new System.Drawing.Point(106, 358);
            this.btnSatisYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(92, 25);
            this.btnSatisYap.TabIndex = 11;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(472, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 323);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblFiyatBaslik);
            this.Controls.Add(this.lblIlacAdi);
            this.Controls.Add(this.lblIlacAdiBaslik);
            this.Controls.Add(this.btnFiyatGor);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.chkSigorta);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBarkod);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSatis";
            this.Text = "FrmSatis";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.CheckBox chkSigorta;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnFiyatGor;
        private System.Windows.Forms.Label lblIlacAdiBaslik;
        private System.Windows.Forms.Label lblIlacAdi;
        private System.Windows.Forms.Label lblFiyatBaslik;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}