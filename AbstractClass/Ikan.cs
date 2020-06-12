using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.AbstractClass
{
    public class Ikan : Hewan
    {
        public override void Bergerak()
        {
            Console.WriteLine("ikan berenang ");
            Console.WriteLine("dengan bantuan sirip dan ekor");
        }
        public override void Makan()
        {
            Console.WriteLine("makanan jentik nyamuk,cacing");
        }

    }
}
