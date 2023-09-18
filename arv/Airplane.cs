using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    internal class Airplane
    {

        public int Capacity;
        public int Engines;
        public void TakeOff()
        {
            Console.WriteLine(" Cabin cew, prepare for takeoff");
        }
        public void Land()
        {
            Console.WriteLine(" The airplane has landed");
        }
    }


        
}
