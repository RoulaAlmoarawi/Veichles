using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    public class Car
    {
        int Speed;
        string Make;
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
