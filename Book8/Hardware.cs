using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book8
{
    class Hardware : Product
    {
        public int weight;

        public Hardware(string name, int price, int weight) {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public override void DisplayProduct() {
            Console.WriteLine("You bought " + name + ", weight " + weight);
        }
    }
}
