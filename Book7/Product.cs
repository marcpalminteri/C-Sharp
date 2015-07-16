using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book7
{
    class Product
    {
        public string name;
        public int price;
        public string category;

        public Product(string name, int price, string category) {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public Product(string name, int price) {
            this.name = name;
            this.price = price;
        }

        public int IncreasePrice(int increase) {
            this.price += increase;
            return this.price;
        }
    }
}
