using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException_p._284
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming.." : "Quiet time..");
        }
    }
}
