using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya ELması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");


            }
            Console.WriteLine("----------------------Metotlar-------------------------");
           
            // encapsulation = kapsülleme ayrı ayrı yazman gereken bir dizini düzenli toplu yazılma.

            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekne2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekne2("Elma", "Elma Armut", 12, 9);
            sepetManager.Ekne2("Karpuz", "Diyarbakır Karpuzu", 12,5);





            Console.ReadKey();

        }
    }
}
