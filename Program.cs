using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using abstraction.AbstractClass;
using abstraction.Interface;
namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pilih hewan :");
            Console.WriteLine("1.Burung");
            Console.WriteLine("2.Harimau");
            Console.WriteLine("3.Ikan");

            Console.Write("pilih hewan [1..3]: ");
            int nomorHewan = Convert.ToInt32(Console.ReadLine());            
           /* Hewan hewan;
            if (nomorHewan == 1)
            {
                hewan = new Burung();
                hewan.Bergerak();
                hewan.Makan();
            }
            else if (nomorHewan == 2)
            {
                hewan = new Harimau();
                hewan.Bergerak();
                hewan.Makan();
            }
            */
            IHewan hewan;
            if (nomorHewan == 1)
            {
                hewan = new Burung();
                hewan.Bergerak();
                hewan.Makan();
            }
            else if (nomorHewan == 2)
            {
                hewan = new Harimau();
                hewan.Bergerak();
                hewan.Makan();
            }
            else
            {
                hewan = new Ikan();
                hewan.Bergerak();
                hewan.Makan();
            }
            Console.ReadKey();
        }
    }
}
