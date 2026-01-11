using System;

namespace EczaneYonetimSistemi.Entities
{
    public class RecetesizIlac : Ilac
    {
        public override decimal SatisTutariHesapla(bool sigortaVarMi)
        {
            // Sigorta dikkate alınmaz, KDV eklenir
            return BirimFiyat + (BirimFiyat * (KdvOrani / 100m));
        }
    }
}
