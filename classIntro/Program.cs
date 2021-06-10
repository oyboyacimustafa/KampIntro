using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmeni = "Engin emiroğ";
            kurs1.izlenmeOrani = 68;


            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.Egitmeni = "Kerem";
            kurs2.izlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "python";
            kurs3.Egitmeni = "Berkay";
            kurs3.izlenmeOrani = 80;

            Console.WriteLine = (kurs1.kursAdi + " " + kurs1.Egitmeni + " " + kurs1.izlenmeOrani);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }
            Console.ReadKey();
        }



        class kurs
        {
            public string kursAdi { get; set; }

            public string Egitmeni { get; set; }

            public int izlenmeOrani { get; set; }

        }

    }
}
