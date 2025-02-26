using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface Idevice
    {
        public const int x = 0;//This is allowed.
        //Interface is a contract between parent class and it is sub classes
        void TurnOn();
        void TurnOff();
        void Restart()
        {
            Console.WriteLine("This is a Default Body.");
        }
    }
}
