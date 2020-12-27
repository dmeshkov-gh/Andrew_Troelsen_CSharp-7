using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleException_p._284
{
    class Program
    {
        static void Main()
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
                Console.WriteLine("**** ERROR! ****");
                Console.WriteLine(e.Message);  
                Console.WriteLine(e.Source);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.TargetSite.DeclaringType);
                Console.WriteLine(e.TargetSite.MemberType);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.HelpLink);
                foreach(DictionaryEntry dictionaryEntry in e.Data)
                    Console.WriteLine("{0}: {1}", dictionaryEntry.Key, dictionaryEntry.Value);
                Console.WriteLine("*** THE END ***");
            }
            Console.ReadKey();
        }
    }
}
