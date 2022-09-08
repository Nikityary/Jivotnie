using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jivotnie
{
    internal class Dog : Animal
    {
        string spasat;
        public Dog(string spasat, string food, string location) : base(food, location)
        {
            this.spasat = spasat;
        }
        public void makeNoise()
        {
            Console.WriteLine("лает");
        }
        public void eat()
        {
            Console.WriteLine("ест");
        }
    }
}