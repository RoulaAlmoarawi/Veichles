using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    internal class Fire_Truck
    {
        int Speed;
        string make;
        int Year;
        string FuelType;
        public void GoForWard()
        {
            Console.WriteLine("Vroom");

        }
        public void Break()
        {
            Console.WriteLine("Your breaked your vechiles");
        }
    }
}
