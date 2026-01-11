namespace EczaneYonetimSistemi
{
    partial class FrmAnaPanel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaPanel));
            this.dgvIlaclar = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSatisEkrani = new System.Windows.Forms.Button();
            this.btnIlacKabul = new System.Windows.Forms.Button();
            this.btnImhaEt = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlaclar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIlaclar
            // 
            this.dgvIlaclar.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlaclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIlaclar.Location = new System.Drawing.Point(165, 0);
            this.dgvIlaclar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIlaclar.Name = "dgvIlaclar";
            this.dgvIlaclar.RowHeadersWidth = 51;
            this.dgvIlaclar.RowTemplate.Height = 24;
            this.dgvIlaclar.Size = new System.Drawing.Size(721, 531);
            this.dgvIlaclar.TabIndex = 0;
            this.dgvIlaclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIlaclar_CellContentClick);
            this.dgvIlaclar.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIlaclar_DataBindingComplete);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Turquoise;
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnSatisEkrani);
            this.pnlMenu.Controls.Add(this.btnIlacKabul);
            this.pnlMenu.Controls.Add(this.btnImhaEt);
            this.pnlMenu.Controls.Add(this.btnYenile);
            this.pnlMenu.Controls.Add(this.btnCikis);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(165, 531);
            this.pnlMenu.TabIndex = 4;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(165, 98);
            this.pnlLogo.TabIndex = 18;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAppName.ForeColor = System.Drawing.Color.Black;
            this.lblAppName.Location = new System.Drawing.Point(0, 81);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(159, 17);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Eczane Yönetim Sistemi";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(165, 81);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnSatisEkrani
            // 
            this.btnSatisEkrani.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSatisEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSatisEkrani.Location = new System.Drawing.Point(0, 391);
            this.btnSatisEkrani.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatisEkrani.Name = "btnSatisEkrani";
            this.btnSatisEkrani.Size = new System.Drawing.Size(165, 28);
            this.btnSatisEkrani.TabIndex = 17;
            this.btnSatisEkrani.Text = "Satış Ekranı";
            this.btnSatisEkrani.UseVisualStyleBackColor = true;
            this.btnSatisEkrani.Click += new System.EventHandler(this.btnSatisEkrani_Click);
            // 
            // btnIlacKabul
            // 
            this.btnIlacKabul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIlacKabul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnIlacKabul.Location = new System.Drawing.Point(0, 419);
            this.btnIlacKabul.Margin = new System.Windows.Forms.Padding(2);
            this.btnIlacKabul.Name = "btnIlacKabul";
            this.btnIlacKabul.Size = new System.Drawing.Size(165, 28);
            this.btnIlacKabul.TabIndex = 16;
            this.btnIlacKabul.Text = "İlaç Kabul";
            this.btnIlacKabul.UseVisualStyleBackColor = true;
            this.btnIlacKabul.Click += new System.EventHandler(this.btnIlacKabul_Click);
            // 
            // btnImhaEt
            // 
            this.btnImhaEt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnImhaEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImhaEt.Location = new System.Drawing.Point(0, 447);
            this.btnImhaEt.Margin = new System.Windows.Forms.Padding(2);
            this.btnImhaEt.Name = "btnImhaEt";
            this.btnImhaEt.Size = new System.Drawing.Size(165, 28);
            this.btnImhaEt.TabIndex = 15;
            this.btnImhaEt.Text = "İmha Et / Sil";
            this.btnImhaEt.UseVisualStyleBackColor = true;
            this.btnImhaEt.Click += new System.EventHandler(this.btnImhaEt_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnYenile.Location = new System.Drawing.Point(0, 475);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(2);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(165, 28);
            this.btnYenile.TabIndex = 14;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCikis.Location = new System.Drawing.Point(0, 503);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(165, 28);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmAnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.dgvIlaclar);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAnaPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eczane Yönetim Sistemi";
            this.Load += new System.EventHandler(this.FrmAnaPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlaclar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIlaclar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSatisEkrani;
        private System.Windows.Forms.Button btnIlacKabul;
        private System.Windows.Forms.Button btnImhaEt;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAppName;
    }
}

