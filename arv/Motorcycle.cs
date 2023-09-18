using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    internal class Motorcycle
    {
        int Speed;
        string Make;
        int Year;
        string FuelTypre;
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
