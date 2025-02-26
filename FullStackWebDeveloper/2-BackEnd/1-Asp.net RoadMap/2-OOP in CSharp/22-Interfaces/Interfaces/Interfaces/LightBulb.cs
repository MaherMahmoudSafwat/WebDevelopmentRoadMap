using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class LightBulb:Idevice
    {
        public void TurnOn()
        {
            Console.WriteLine("LightBulb is Turned On.");
        }
        public void TurnOff()
        {
            Console.WriteLine("LightBulb is Turned Off.");
        }
    }
}
