using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book8
{
    class Product
    {
        public string name;
        public int price;

        public virtual void DisplayProduct() {
            Console.WriteLine("This is a parent class: " + name);
        }
    }
}
