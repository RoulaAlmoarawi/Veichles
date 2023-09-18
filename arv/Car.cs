using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    internal class car : Vechiles 
    {
        public int Doors;
        public bool isconvertible;


        public void Honik()
        {
            Console.WriteLine("Toot, Toot");
        }
        public void PobTheTrunk()
        {
            Console.WriteLine("The trunk was opened");
        }
    }
}
