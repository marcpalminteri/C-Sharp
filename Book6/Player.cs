using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book6
{
    class Player
    {
        string name;
        public int age;
        public string country;
  
        public Player(string name, int age, string country)
        {
            this.name = name;
            this.age = age;
            this.country = country;
        }

        public Player(string name)
        {
            this.name = name;
        }

        public Player() {
            this.name = "Default";
            this.age = 0;
            this.country = "N/A";
        }
    }
}
