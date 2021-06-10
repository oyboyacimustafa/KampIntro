using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
    {
    static void Main(string[] args)
    {
        string[] kurslar = new string[] { "yazilim gelistirici yerlestirme kampi", "programalaya baslangic icin temel kurslar", 
            "java" ,"pyton","c++" };

        for (int i = 0; i <kurslar.Length; i++)
        {
            Console.WriteLine("for bitti");
        }
        Console.WriteLine(kurslar[i]);


            foreach (string kurs in kurslar)
            {
            Console.WriteLine("kurs");
        }
    }


            Console.WriteLine("sayfa sonu-footer");
        }

        Console.ReadKey();
    }

}
