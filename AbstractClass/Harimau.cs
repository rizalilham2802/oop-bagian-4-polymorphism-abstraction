using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.AbstractClass
{
    public class Harimau : Hewan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Harimau berlari di daratan");
            Console.WriteLine("dengan bantuan kaki");
        }
        public override void Makan()
        {
            Console.WriteLine("Makan daging");
        }
        
    }
}
