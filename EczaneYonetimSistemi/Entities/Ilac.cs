using System;

namespace EczaneYonetimSistemi.Entities
{
    public abstract class Ilac
    {
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public string IlacAdi { get; set; }

        public decimal BirimFiyat { get; set; }
        public decimal KdvOrani { get; set; }

        // EKLENDİ (hataların ana nedeni)
        public bool ReceteZorunlulugu { get; set; }
        public int KategoriId { get; set; }

        private DateTime _sonKullanmaTarihi;
        public DateTime SonKullanmaTarihi
        {
            get { return _sonKullanmaTarihi; }
            set
            {
                // Validation + kapsülleme:
                // Veritabanında geçmiş SKT olabilir (imha/eskiler). Bu yüzden exception atmıyoruz.
                // Tarihi sadece "Date" kısmına indirip normalize ediyoruz (saat/dakika farkı vs. kalkar).
                _sonKullanmaTarihi = value.Date;
            }
        }

        private int _stokAdedi;
        public int StokAdedi
        {
            get { return _stokAdedi; }
            set
            {
                // Validation: stok negatif olamaz (kapsülleme)
                if (value < 0)
                    throw new Exception("Stok 0'ın altına düşemez.");

                _stokAdedi = value;
            }
        }

        public abstract decimal SatisTutariHesapla(bool sigortaVarMi);
    }
}
