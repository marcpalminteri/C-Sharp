using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book8
{
    class Software : Product
    {
        public int version;

        public Software (string name, int price, int version){
            this.name = name;
            this.price = price;
            this.version = version;
        }

        public override void DisplayProduct() {
            Console.WriteLine("You bought " + name + ", version " + version);
        }
    }
}
