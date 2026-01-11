namespace EczaneYonetimSistemi
{
    partial class FrmIlacKabul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIlacKabul));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.dtpSkt = new System.Windows.Forms.DateTimePicker();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.chkReceteli = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(210, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlaç Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(210, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(54, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Son Kullanma Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(9, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kategori";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(98, 28);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(76, 20);
            this.txtBarkod.TabIndex = 6;
            this.txtBarkod.Leave += new System.EventHandler(this.txtBarkod_Leave);
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(282, 30);
            this.txtIlacAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(76, 20);
            this.txtIlacAdi.TabIndex = 7;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(282, 86);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(76, 20);
            this.txtBirimFiyat.TabIndex = 8;
            this.txtBirimFiyat.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(98, 86);
            this.nudStok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudStok.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(75, 20);
            this.nudStok.TabIndex = 9;
            // 
            // dtpSkt
            // 
            this.dtpSkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpSkt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSkt.Location = new System.Drawing.Point(186, 141);
            this.dtpSkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpSkt.Name = "dtpSkt";
            this.dtpSkt.Size = new System.Drawing.Size(151, 23);
            this.dtpSkt.TabIndex = 10;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(82, 193);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(92, 21);
            this.cmbKategori.TabIndex = 11;
            // 
            // chkReceteli
            // 
            this.chkReceteli.AutoSize = true;
            this.chkReceteli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkReceteli.Location = new System.Drawing.Point(222, 193);
            this.chkReceteli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkReceteli.Name = "chkReceteli";
            this.chkReceteli.Size = new System.Drawing.Size(78, 21);
            this.chkReceteli.TabIndex = 12;
            this.chkReceteli.Text = "Reçeteli";
            this.chkReceteli.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKaydet.Location = new System.Drawing.Point(222, 262);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 25);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGuncelle.Location = new System.Drawing.Point(98, 262);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(92, 25);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIlacKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(864, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkReceteli);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.dtpSkt);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtIlacAdi);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(880, 500);
            this.Name = "FrmIlacKabul";
            this.Text = "İlaç Kabul";
            this.Load += new System.EventHandler(this.FrmIlacKabul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.DateTimePicker dtpSkt;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.CheckBox chkReceteli;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}