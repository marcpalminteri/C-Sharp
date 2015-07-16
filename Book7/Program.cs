using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Product p = new Product("Laptop", 40, "Electronics");
            Product p2 = new Product("Apple", 2);
            p2.category = "Fruits";

            Console.WriteLine("The price of " + p.name + " is: " + p.price);
            Console.WriteLine("The new price of " + p.name + " is: " + p.IncreasePrice(20));
            */

            Car a = new Car("Fiat", 80);
            Console.WriteLine("The speed of the " + a.name + " is: " + a.speed);
            Console.WriteLine("The new speed of the " + a.name + " is: " + a.speedChange(20));

            Console.Read();
        }
    }
}
