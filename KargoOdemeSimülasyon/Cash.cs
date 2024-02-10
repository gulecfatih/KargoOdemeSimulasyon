using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoOdemeSimülasyon
{
    public class Cash:IKargoOdemeYontemleri
    {
        public void OdemeYap(float tutar)
        {
            Console.WriteLine($"Nakit {tutar} TL ödeme yapıldı.");
        }
    }
}
