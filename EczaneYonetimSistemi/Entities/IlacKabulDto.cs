using System;

namespace EczaneYonetimSistemi.Entities
{
    public class IlacKabulDto
    {
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public string IlacAdi { get; set; }
        public int StokAdedi { get; set; }
        public decimal BirimFiyat { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public bool ReceteZorunlulugu { get; set; }
        public int KategoriId { get; set; }
    }
}
