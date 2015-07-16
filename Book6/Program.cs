using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book6
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("Guy", 50, "Place");

            Player p2 = new Player();
            p2.name = "Gal";
            p2.age = 49;
            p2.country = "Other place";

            Player p3 = new Player();

            Console.WriteLine(p.name + " " + p.age + " " + p.country);
            Console.WriteLine(p2.name + " " + p2.age + " " + p2.country);
            Console.WriteLine(p3.name + " " + p3.age + " " + p3.country);
        }
    }
}
