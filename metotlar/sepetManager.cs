using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class sepetManager
    {
        public void Ekle (Urun urun)
        {
            Console.WriteLine("Tebrikler .Sepete Eklendi! : " + urun.Adi);

        }
        public void Ekne2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler .Sepete Eklendi! : " + urunAdi);
        }
    }
}
