using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EczaneYonetimSistemi.DataAccess;
using EczaneYonetimSistemi.Business;
using EczaneYonetimSistemi.Entities;

namespace EczaneYonetimSistemi
{
    public partial class FrmSatis : Form
    {
        
        private Ilac _seciliIlac;

        public FrmSatis()
        {
            InitializeComponent();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string barkod = txtBarkod.Text.Trim();

            if (string.IsNullOrWhiteSpace(barkod))
            {
                MessageBox.Show("Lütfen barkod girin.");
                return;
            }

            IlacRepository repo = new IlacRepository();
            IlacSatisDto dto = repo.GetByBarkod(barkod);

            if (dto == null)
            {
                _seciliIlac = null;
                lblIlacAdi.Text = "-";
                lblTutar.Text = "0,00";
                MessageBox.Show("Bu barkoda ait ilaç bulunamadı.");
                return;
            }

            
            _seciliIlac = IlacFactory.CreateFromDto(dto);

            lblIlacAdi.Text = _seciliIlac.IlacAdi;
            lblTutar.Text = "0,00";
        }

        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            if (_seciliIlac == null)
            {
                MessageBox.Show("Önce ilacı bul (Bul).");
                return;
            }

            bool sigortaVarMi = chkSigorta.Checked;

            decimal tutar = _seciliIlac.SatisTutariHesapla(sigortaVarMi);

            lblTutar.Text = tutar.ToString("0.00");
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (_seciliIlac == null)
            {
                MessageBox.Show("Önce ilacı bul (Bul).");
                return;
            }

            int adet = (int)nudAdet.Value;

            
            if (_seciliIlac.SonKullanmaTarihi.Date < DateTime.Today)
            {
                MessageBox.Show("Son kullanma tarihi geçmiş ilaç satılamaz.");
                return;
            }

            IlacRepository repo = new IlacRepository();
            bool basarili = repo.StokDus(_seciliIlac.Id, adet);

            if (!basarili)
            {
                MessageBox.Show("Stok yetersiz! Satış yapılamadı.");
                return;
            }

            MessageBox.Show("Satış başarılı. Stok düşürüldü.");

            
            txtBarkod.Clear();
            lblIlacAdi.Text = "-";
            lblTutar.Text = "0,00";
            chkSigorta.Checked = false;
            nudAdet.Value = 1;
            _seciliIlac = null;
        }

    }
}
