using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    internal class Vechiles
    {
        public string Make;
        public int Year;
        public string Model;
        public string Color;
        public double Weight;
        public int speed;
        public void Move()
        {
            Console.WriteLine("The vechile is moving");
        }
        public void stop()
        {
            Console.WriteLine("The vechile has stopped");
        }
        public void FuelUp()
        {
            Console.WriteLine(" The tank is now full of fuel");
        }


    }
    
}
