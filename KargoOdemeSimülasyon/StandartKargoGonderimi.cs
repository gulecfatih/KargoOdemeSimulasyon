using KargoOdemeSimülasyon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoOdemeSimülasyon
{
    public class StandartKargoGonderimi : IKargoUcretHesaplama
    {
        public float KargoUcretiHesapla(float agirlik)
        {
            return agirlik * 3.5F; // Standart kargo ücreti: ağırlık * 3.5
        }
    }
}
