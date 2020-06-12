using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.AbstractClass
{
    public class Burung : Hewan
    {
       public override void Bergerak()
       {
           Console.WriteLine("burung terbang di langit");
           Console.WriteLine("dengan bantuan sayap");
       }
       public override void Makan()
       {
           Console.WriteLine("makan biji bijian dan buah buahan");
       }
    }
}
