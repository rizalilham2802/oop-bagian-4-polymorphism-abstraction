using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.Interface
{
    public class Harimau : IHewan
    {
        public void Bergerak()
        {
            Console.WriteLine("Harimau berlari di daratan");
            Console.WriteLine("dengan bantuan kaki");
        }
        public void Makan()
        {
            Console.WriteLine("Makan daging");
        }
        
    }
}
