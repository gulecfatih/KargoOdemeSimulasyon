using KargoOdemeSimülasyon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoOdemeSimülasyon
{
    public class KargoIslemi
    {
        private IKargoUcretHesaplama _kargoUcretHesaplama;
        private IKargoOdemeYontemleri _kargoOdemeYontemleri;


        public void KargoHesaplama(IKargoUcretHesaplama kargoUcretHesaplama)
        {
            _kargoUcretHesaplama = kargoUcretHesaplama;
        }
        public void KargoOdeme(IKargoOdemeYontemleri kargoOdemeYontemleri)
        {
            _kargoOdemeYontemleri = kargoOdemeYontemleri;
        }

        public float HesaplaKargoUcreti(float agirlik)
        {
            if (_kargoUcretHesaplama == null)
            {
                Console.WriteLine("Lütfen kargo stratejisini seçin.");
                return 0.0F;
            }

            return _kargoUcretHesaplama.KargoUcretiHesapla(agirlik);
        }
        public void OdemeYap(float tutar)
        {
            if (_kargoOdemeYontemleri == null)
            {
                Console.WriteLine("Lütfen kargo stratejisini seçin.");
            }
            _kargoOdemeYontemleri.OdemeYap(tutar);
        }
    }
}
