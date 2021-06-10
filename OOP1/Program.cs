using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.ıd = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInstock = 3;

            product product2 = new product { ıd = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInstock = 5 }
            
            ProductManager productManager = new ProductManager();
            productManager.add(product1);
            Console.WriteLine(product1.ProductName);








            Console.ReadKey();
        }
    }
}
