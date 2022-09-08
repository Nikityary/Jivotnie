using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jivotnie
{
    internal class Horse : Animal
    {
        string run;
        public Horse(string run, string food, string location) : base(food, location)
        {
            this.run = run;
        }
        public void makeNoise()
        {
            Console.WriteLine("привет");
        }
        public void eat()
        {
            Console.WriteLine("ест");
        }
    }
}