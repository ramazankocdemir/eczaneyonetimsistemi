using System;
using EczaneYonetimSistemi.Entities;

namespace EczaneYonetimSistemi.Business
{
    public static class IlacFactory
    {
        public static Ilac CreateFromDto(IlacSatisDto dto)
        {
            if (dto == null) return null;

            Ilac ilac;

            if (dto.ReceteZorunlulugu)
                ilac = new ReceteliIlac();
            else
                ilac = new RecetesizIlac();

            ilac.Id = dto.Id;
            ilac.BarkodNo = dto.BarkodNo;
            ilac.IlacAdi = dto.IlacAdi;
            ilac.BirimFiyat = dto.BirimFiyat;
            ilac.KdvOrani = dto.KdvOrani;

            // Kapsülleme validasyonları bu set’lerde çalışır
            ilac.SonKullanmaTarihi = dto.SonKullanmaTarihi;
            ilac.StokAdedi = dto.StokAdedi;

            return ilac;
        }
    }
}
