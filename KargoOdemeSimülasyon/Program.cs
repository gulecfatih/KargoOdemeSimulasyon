using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoOdemeSimülasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"LÜTFEN GÖNDERİLECEK KARGONUN AĞIRLIĞINI GİRİNİZ.");

            float agirlik = float.Parse(Console.ReadLine());
            KargoIslemi kargo = new KargoIslemi();
            float kargoUcreti=0F;
            if (agirlik > 10)
            {

                kargo.KargoHesaplama(new ExpressKargoGonderimi());
                kargoUcreti = kargo.HesaplaKargoUcreti(agirlik);
                Console.WriteLine($"Express kargo ücreti: {kargoUcreti}");
            }
            else
            {
                Console.WriteLine($"LÜTFEN GÖNDERİLECEK KARGONUN STANDART MI YOKSA EXPRESS YÖNTEM İLE GİDECEĞİNİ GİRİNİZ." +
                    $"\r\n STANDART YÖNTEM İSE 1 YAZINIZ." +
                    $"\r\n EXPRESS  YÖNTEM İSE 2 YAZINIZ.");
                int hesaplamaYontemi = Convert.ToInt32(Console.ReadLine());
                if (Convert.ToInt32(hesaplamaYontemi) == 1)
                {
                    kargo.KargoHesaplama(new StandartKargoGonderimi());
                    kargoUcreti = kargo.HesaplaKargoUcreti(agirlik);
                    Console.WriteLine($"Standart kargo ücreti: {kargoUcreti}");
                }
                else if (Convert.ToInt32(hesaplamaYontemi) == 2)
                {
                    kargo.KargoHesaplama(new ExpressKargoGonderimi());
                    kargoUcreti = kargo.HesaplaKargoUcreti(agirlik);
                    Console.WriteLine($"Express kargo ücreti: {kargoUcreti}");
                }
            }
            Console.WriteLine($"LÜTFEN ÖDEME YÖNTEMİNİ SEÇİNİZ." +
               $"\r\n NAKİT İSE 1 YAZINIZ." +
               $"\r\n KREDİ KARTI İSE 2 YAZINIZ.");
            int odemeYontemi = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToInt32(odemeYontemi) == 1)
            {
                kargo.KargoOdeme(new Cash());
                kargo.OdemeYap(kargoUcreti);
            }
            else if (Convert.ToInt32(odemeYontemi) == 2)
            {
                kargo.KargoOdeme(new CrediCard());
                kargo.OdemeYap(kargoUcreti);
            }

            Console.ReadLine();
        }
    }
}
