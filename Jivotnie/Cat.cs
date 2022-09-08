using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jivotnie
{
    internal class Cat : Animal
    {
        string linyat;
        public Cat(string linyat, string food, string location) : base(food, location)
        {
            this.linyat = linyat;
        }
        public void makeNoise()
        {
            Console.WriteLine("мяукает");
        }
        public void eat()
        {
            Console.WriteLine("ест");
        }
    }

}