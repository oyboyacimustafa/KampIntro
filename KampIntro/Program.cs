using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not yourself - kendini tekrarlama
            // alias - değer tutucu

            //string kategoriEtiketi = "kategori";
           // int ogrenciSayisi = 32000;
           // double faizOrani = 1.45;
            //bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalıs butunu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artis butunu");
            }
            else
            {
                Console.WriteLine("esittir butonu");
            }
            {

            }
            //if (sistemeGirisYapmisMi == true)
           // {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

           // }
            else
           // {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.ReadKey();

        }
    }
}
