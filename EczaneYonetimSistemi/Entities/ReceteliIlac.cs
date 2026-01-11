using System;

namespace EczaneYonetimSistemi.Entities
{
    public class ReceteliIlac : Ilac
    {
        // Sigortalıysa %10 ödeme (istersen %20 yaparız)
        public override decimal SatisTutariHesapla(bool sigortaVarMi)
        {
            if (sigortaVarMi)
                return BirimFiyat * 0.10m; // müşteri ödemesi
            return BirimFiyat; // sigortasız tam
        }
    }
}
