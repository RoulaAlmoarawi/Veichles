using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    public class Bus
    {
        int Speed;
        string Make;
        int Year;
        string FuelType;

        public void GoForward()
        {
            Console.WriteLine("Vroom");


        }
        public void Break()
        {
            Console.WriteLine("Your breaked your vechiles");
        }
    }
}
