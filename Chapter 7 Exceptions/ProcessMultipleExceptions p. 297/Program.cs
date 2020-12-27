using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions_p._297
{
    class Program
    {
        //Сначала должны обрабатываться наиболее специфичные исключения, поскольку исключение будет обрабатываться
        //первым подходящим блоком catch
        static void Main(string[] args)
        {
            Car myCar = new Car("Rusty", 90);
            try
            {
                myCar.Accelerate(-10);
            }
            catch(CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
