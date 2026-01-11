using System;

namespace EczaneYonetimSistemi.Entities
{
    // Repository’nin new'leyebilmesi için somut sınıf
    public class IlacEntity : Ilac
    {
        public override decimal SatisTutariHesapla(bool sigortaVarMi)
        {
            // basit hesap: KDV dahil tutar
            decimal kdvDahil = BirimFiyat * (1 + (KdvOrani / 100m));

            // sigorta varsa örnek indirim (istersen sonra değiştiririz)
            if (sigortaVarMi)
                kdvDahil *= 0.80m;

            return decimal.Round(kdvDahil, 2);
        }
    }
}
