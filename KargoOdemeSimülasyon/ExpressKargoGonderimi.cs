using KargoOdemeSimülasyon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoOdemeSimülasyon
{
    public class ExpressKargoGonderimi : IKargoUcretHesaplama
    {
        public float KargoUcretiHesapla(float agirlik)
        {
            return agirlik * 7.0F; // Express kargo ücreti: ağırlık * 7.0
        }
        
    }
}
