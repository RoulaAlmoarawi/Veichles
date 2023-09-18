using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    internal class Boat
    {
        public int Lenght;
        public string HullDesign;
        public bool HasCabin;

        public void DropAnchor()
        {
            Console.WriteLine(" The anchor was dropped");
        }
        public void Sink()
        {
            Console.WriteLine("Ohhh NOO, we are sinking");
        }
    }
}
