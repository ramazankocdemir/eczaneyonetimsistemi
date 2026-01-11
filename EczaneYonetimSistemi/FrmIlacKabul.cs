using System;
using System.Globalization;
using System.Windows.Forms;
using EczaneYonetimSistemi.DataAccess;

namespace EczaneYonetimSistemi
{
    public partial class FrmIlacKabul : Form
    {
        private int? _seciliIlacId = null;

        public FrmIlacKabul()
        {
            InitializeComponent();
        }

        private void FrmIlacKabul_Load(object sender, EventArgs e)
        {
            dtpSkt.MinDate = DateTime.Today;
            dtpSkt.Value = DateTime.Today;

            KategorileriDoldur();

            
            ModAyarla(false);
        }

        private void KategorileriDoldur()
        {
            try
            {
                var repo = new KategoriRepository();
                var list = repo.GetAll();

                cmbKategori.DataSource = list;
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "Id";
                cmbKategori.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori yüklenemedi: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var repoKontrol = new IlacRepository();
            bool barkodVar = repoKontrol.BarkodVarMi(txtBarkod.Text.Trim());

            if (barkodVar)
            {
                MessageBox.Show(
                    "Bu barkod zaten kayıtlı.\nGüncelleme moduna geçildi.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                BarkoddanIlacYukle(txtBarkod.Text.Trim());
                ModAyarla(true); 
                                 
                return;
            }

            if (!ZorunluAlanKontrol()) return;

            DateTime skt = dtpSkt.Value.Date;
            if (skt < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihli ilaç kaydedilemez.");
                return;
            }

            if (!decimal.TryParse(txtBirimFiyat.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("tr-TR"), out decimal birimFiyat))
            {
                MessageBox.Show("Birim fiyat sayısal olmalı. Örn: 120,50");
                return;
            }

            if (birimFiyat <= 0)
            {
                MessageBox.Show("Birim fiyat 0'dan büyük olmalı.");
                return;
            }

            int stok = (int)nudStok.Value;
            bool recete = chkReceteli.Checked;

            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategori seçiniz.");
                return;
            }

            int kategoriId = Convert.ToInt32(cmbKategori.SelectedValue);

            try
            {
                var ilacRepo = new IlacRepository();
                int yeniId = ilacRepo.Insert(
                    txtBarkod.Text.Trim(),
                    txtIlacAdi.Text.Trim(),
                    stok,
                    birimFiyat,
                    skt,
                    recete,
                    kategoriId
                );

                MessageBox.Show("İlaç eklendi. Id: " + yeniId);
                FormuTemizle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt hatası: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            string barkod = txtBarkod.Text.Trim();
            if (string.IsNullOrWhiteSpace(barkod))
            {
                MessageBox.Show("Barkod boş olamaz.");
                return;
            }

            
            if (_seciliIlacId == null)
            {
                try
                {
                    var repoKontrol = new IlacRepository();
                    var ilac = repoKontrol.GetByBarkodForKabul(barkod);
                    if (ilac == null)
                    {
                        MessageBox.Show("Bu barkodla kayıtlı ilaç bulunamadı.");
                        return;
                    }
                    _seciliIlacId = ilac.Id; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İlaç kontrol hatası: " + ex.Message);
                    return;
                }
            }

            
            if (!ZorunluAlanKontrol()) return;

            
            DateTime skt = dtpSkt.Value.Date;
            if (skt < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihli ilaç güncellenemez.");
                return;
            }

            
            if (!decimal.TryParse(txtBirimFiyat.Text, NumberStyles.Number,
                CultureInfo.GetCultureInfo("tr-TR"), out decimal birimFiyat))
            {
                MessageBox.Show("Birim fiyat sayısal olmalı. Örn: 120,50");
                return;
            }

            if (birimFiyat <= 0)
            {
                MessageBox.Show("Birim fiyat 0'dan büyük olmalı.");
                return;
            }

            int stok = (int)nudStok.Value;
            bool recete = chkReceteli.Checked;

            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategori seçiniz.");
                return;
            }

            int kategoriId = Convert.ToInt32(cmbKategori.SelectedValue);

            
            try
            {
                var repo = new IlacRepository();

                bool ok = repo.UpdateByBarkod(
                    barkod,
                    txtIlacAdi.Text.Trim(),
                    stok,
                    birimFiyat,
                    skt,
                    recete,
                    kategoriId
                );

                MessageBox.Show(ok ? "İlaç güncellendi." : "Güncelleme yapılamadı.");

                if (ok) FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }


        private void BarkoddanIlacYukle(string barkod)
        {
            if (string.IsNullOrWhiteSpace(barkod))
            {
                _seciliIlacId = null;
                ModAyarla(false);
                return;
            }

            try
            {
                var repo = new IlacRepository();
                var ilac = repo.GetByBarkodForKabul(barkod);

                if (ilac == null)
                {
                    
                    _seciliIlacId = null;
                    ModAyarla(false);
                    return;
                }

                
                _seciliIlacId = ilac.Id;

                txtIlacAdi.Text = ilac.IlacAdi;
                nudStok.Value = ilac.StokAdedi < 0 ? 0 : ilac.StokAdedi;
                txtBirimFiyat.Text = ilac.BirimFiyat.ToString("0.##", CultureInfo.GetCultureInfo("tr-TR"));
                dtpSkt.Value = ilac.SonKullanmaTarihi < DateTime.Today ? DateTime.Today : ilac.SonKullanmaTarihi;
                chkReceteli.Checked = ilac.ReceteZorunlulugu;

                if (cmbKategori.DataSource != null)
                    cmbKategori.SelectedValue = ilac.KategoriId;

                
                ModAyarla(true);
            }
            catch
            {
                
                _seciliIlacId = null;
                ModAyarla(false);
            }
        }

        
        private void txtBarkod_Leave(object sender, EventArgs e)
        {
            BarkoddanIlacYukle(txtBarkod.Text.Trim());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool ZorunluAlanKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtBarkod.Text) || string.IsNullOrWhiteSpace(txtIlacAdi.Text))
            {
                MessageBox.Show("Barkod ve İlaç Adı boş olamaz.");
                return false;
            }

            if (cmbKategori.SelectedIndex < 0)
            {
                MessageBox.Show("Kategori seçiniz.");
                return false;
            }

            return true;
        }

        private void ModAyarla(bool kayitVar)
        {
            btnGuncelle.Enabled = kayitVar;
            btnKaydet.Enabled = !kayitVar;
        }

        private void FormuTemizle()
        {
            _seciliIlacId = null;

            txtBarkod.Clear();
            txtIlacAdi.Clear();
            nudStok.Value = 0;
            txtBirimFiyat.Clear();
            dtpSkt.Value = DateTime.Today;
            chkReceteli.Checked = false;
            cmbKategori.SelectedIndex = -1;

            
            ModAyarla(false);

            txtBarkod.Focus();
        }
    }
}
