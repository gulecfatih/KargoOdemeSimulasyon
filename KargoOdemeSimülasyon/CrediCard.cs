using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoOdemeSimülasyon
{
    internal class CrediCard : IKargoOdemeYontemleri
    {
        public void OdemeYap(float tutar)
        {
            Console.WriteLine($"Kredi Kartı ile {tutar} TL ödeme yapıldı.");
        }
    }

}
