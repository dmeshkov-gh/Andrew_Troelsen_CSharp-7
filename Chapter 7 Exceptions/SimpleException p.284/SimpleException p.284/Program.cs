using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException_p._284
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.Source);
            }
            Console.ReadKey();
        }
    }
}
