using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.Interface
{
    public class Burung : IHewan
    {
        public void Bergerak()
       {
           Console.WriteLine("burung terbang di langit");
           Console.WriteLine("dengan bantuan sayap");
       }
       public void Makan()
       {
           Console.WriteLine("makan biji bijian dan buah buahan");
       }
    }
    }
