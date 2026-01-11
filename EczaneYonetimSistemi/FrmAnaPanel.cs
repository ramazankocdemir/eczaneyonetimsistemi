using System;
using System.Drawing;
using System.Windows.Forms;
using EczaneYonetimSistemi.DataAccess;
using EczaneYonetimSistemi.Entities;

namespace EczaneYonetimSistemi
{
    public partial class FrmAnaPanel : Form
    {
        public FrmAnaPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = "Eczane Otomasyonu - Ana Panel";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1200, 700);
            this.WindowState = FormWindowState.Normal; 
        }


        private void GridAyarla()
        {
            
            dgvIlaclar.AutoGenerateColumns = true; 
            dgvIlaclar.AllowUserToAddRows = false;
            dgvIlaclar.AllowUserToDeleteRows = false;
            dgvIlaclar.ReadOnly = true;
            dgvIlaclar.MultiSelect = false;
            dgvIlaclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIlaclar.RowHeadersVisible = false;
            dgvIlaclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIlaclar.BackgroundColor = Color.White;
            dgvIlaclar.BorderStyle = BorderStyle.None;

            dgvIlaclar.EnableHeadersVisualStyles = false;
            dgvIlaclar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvIlaclar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvIlaclar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvIlaclar.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvIlaclar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            
        }

        private void FrmAnaPanel_Load(object sender, EventArgs e)
        {
            

            IlaclariYukle();
            pnlMenu.Controls.SetChildIndex(btnSatisEkrani, 0);
            pnlMenu.Controls.SetChildIndex(btnIlacKabul, 0);
            pnlMenu.Controls.SetChildIndex(btnImhaEt, 0);
            pnlMenu.Controls.SetChildIndex(btnYenile, 0);
            pnlMenu.Controls.SetChildIndex(btnCikis, 0);

            var repo = new IlacRepository();
            dgvIlaclar.AutoGenerateColumns = true;
            dgvIlaclar.DataSource = repo.GetAll();

            
            dgvIlaclar.ReadOnly = true;                 
            dgvIlaclar.EditMode = DataGridViewEditMode.EditProgrammatically; 
            dgvIlaclar.AllowUserToAddRows = false;
            dgvIlaclar.AllowUserToDeleteRows = false;
            dgvIlaclar.MultiSelect = false;
            dgvIlaclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            GridKolonDuzenle();

            
            if (dgvIlaclar.Columns["ReceteZorunlulugu"] != null)
            {
                dgvIlaclar.Columns["ReceteZorunlulugu"].ReadOnly = true;
            }

            SatirlariRenklendir();

            
            btnYenile.BringToFront();
            btnCikis.BringToFront();
        }

        
        private void dgvIlaclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvIlaclar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SatirlariRenklendir();
        }

        private void IlaclariYukle()
        {
            var repo = new IlacRepository();
            dgvIlaclar.AutoGenerateColumns = true;
            dgvIlaclar.DataSource = repo.GetAll();
            GridKolonDuzenle();
            SatirlariRenklendir();
        }

        private void GridKolonDuzenle()
        {
            if (dgvIlaclar.Columns.Count == 0) return;

            
            Gizle("KategoriId");
            Gizle("KdvOrani");
            Gizle("Id");

            
            Baslik("BarkodNo", "Barkod");
            Baslik("IlacAdi", "İlaç Adı");
            Baslik("StokAdedi", "Stok");
            Baslik("BirimFiyat", "Birim Fiyat");
            Baslik("SonKullanmaTarihi", "SKT");
            Baslik("ReceteZorunlulugu", "Reçeteli mi?");
            Baslik("KategoriAdi", "Kategori");

            
            if (dgvIlaclar.Columns["BirimFiyat"] != null)
                dgvIlaclar.Columns["BirimFiyat"].DefaultCellStyle.Format = "N2";

            if (dgvIlaclar.Columns["SonKullanmaTarihi"] != null)
                dgvIlaclar.Columns["SonKullanmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";

            
            Agirlik("IlacAdi", 180);
            Agirlik("BarkodNo", 90);
            Agirlik("StokAdedi", 70);
            Agirlik("BirimFiyat", 90);
            Agirlik("SonKullanmaTarihi", 90);
            Agirlik("KategoriAdi", 90);
            Agirlik("ReceteZorunlulugu", 80);
        }

        private void Gizle(string col)
        {
            if (dgvIlaclar.Columns[col] != null)
                dgvIlaclar.Columns[col].Visible = false;
        }

        private void Baslik(string col, string text)
        {
            if (dgvIlaclar.Columns[col] != null)
                dgvIlaclar.Columns[col].HeaderText = text;
        }

        private void Agirlik(string col, int w)
        {
            if (dgvIlaclar.Columns[col] != null)
                dgvIlaclar.Columns[col].FillWeight = w;
        }

        private void SatirlariRenklendir()
        {
            DateTime bugun = DateTime.Today;
            DateTime ucAySonra = bugun.AddMonths(3);

            foreach (DataGridViewRow row in dgvIlaclar.Rows)
            {
                if (row.IsNewRow) continue;

                var item = row.DataBoundItem as IlacListeDto;
                if (item == null) continue;

                int stok = item.StokAdedi;
                DateTime skt = item.SonKullanmaTarihi;

                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;

                if (stok <= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    continue;
                }

                if (skt < bugun)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    continue;
                }

                if (skt <= ucAySonra)
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                    continue;
                }
            }
        }

        private void btnImhaEt_Click(object sender, EventArgs e)
        {
            if (dgvIlaclar.CurrentRow == null || dgvIlaclar.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Lütfen listeden bir ilaç seçin.");
                return;
            }

            var item = dgvIlaclar.CurrentRow.DataBoundItem as IlacListeDto;
            if (item == null)
            {
                MessageBox.Show("Seçili satır okunamadı.");
                return;
            }

            int id = item.Id;
            string ad = item.IlacAdi;
            DateTime skt = item.SonKullanmaTarihi;

            if (skt >= DateTime.Today)
            {
                MessageBox.Show("Bu ilacın son kullanma tarihi geçmemiş. İmha edilemez.");
                return;
            }

            DialogResult onay = MessageBox.Show(
                $"'{ad}' ilacı imha edilecek ve veritabanından silinecek. Emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (onay != DialogResult.Yes) return;

            var repo = new IlacRepository();
            repo.DeleteById(id);
            IlaclariYukle();
        }

        private void btnSatisEkrani_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmSatis())
                frm.ShowDialog();

            IlaclariYukle();
        }

        private void btnIlacKabul_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmIlacKabul())
                frm.ShowDialog();

            IlaclariYukle();
        }

        

        private void btnYenile_Click(object sender, EventArgs e)
        {
            
            IlaclariYukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(
                "Çıkış yapmak istiyor musun?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc != DialogResult.Yes) return;

            
            this.Hide();

            
            using (var frm = new FrmLogin())
            {
                frm.ShowDialog();
            }

            
            this.Close();
        }
    }
}
