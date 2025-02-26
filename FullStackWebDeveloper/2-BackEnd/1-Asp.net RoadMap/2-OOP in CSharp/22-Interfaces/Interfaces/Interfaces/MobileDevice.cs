using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class MobileDevice : Idevice,IRestartable 
    {
        //Implicit Implementation
        public void TurnOn()
        {
            Console.WriteLine("Mobile is Turned On.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Mobile is Turned Off.");
        }
        public void Restart()
        {
            Console.WriteLine("Mobile is Restarted.");
        }
    }
}
