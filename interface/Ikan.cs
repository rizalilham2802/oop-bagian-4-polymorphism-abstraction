using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.Interface
{
    public class Ikan : IHewan
    {
        public void Bergerak()
        {
            Console.WriteLine("ikan berenang ");
            Console.WriteLine("dengan bantuan sirip dan ekor");
        }
        public void Makan()
        {
            Console.WriteLine("makanan jentik nyamuk,cacing");
        }

    }
}
