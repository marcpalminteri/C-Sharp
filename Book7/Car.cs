using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book7
{
    class Car
    {
        public string name;
        public int speed;

        public Car(string name, int speed) {
            this.name = name;
            this.speed = speed;
        }

        public int speedChange(int x) {
            return this.speed -= x;
        }
    }
}
