using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book8
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product();
            a.name = "Apple";
            a.price = 10;
            a.DisplayProduct();

            Product b = new Software("Windows 7", 150, 3);
            b.DisplayProduct();

            Hardware c = new Hardware("Laptop", 500, 2);
            c.DisplayProduct();

            Console.Read();
        }
    }
}
