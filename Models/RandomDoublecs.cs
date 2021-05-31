using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetRandomDouble.Models
{
    public class RandomDouble
    {
        public double Min { get; }
        public double Max { get; }


        public RandomDouble()
        {
            Random rnd = new Random();
            this.Min = rnd.Next(1,100)+ rnd.NextDouble();

            this.Max = rnd.Next(101, 1000) + rnd.NextDouble();
        }




    }
}
