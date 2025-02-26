using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ComputerDevice:Idevice,IRestartable
    {
        //When SubClass inherits a method from interface class it should takes the method signtaure as it is.
        //It should have the same access modifiers return type and method name and the number of parameters with it is types.
        //All Access Modifiers Methods in Interface class are public.
        //Implicit Implementation
        public void TurnOn()
        {
            Console.WriteLine("Computer is Turned On.[Implementation]");
        }
        public void TurnOff(int y)
        {
            Console.WriteLine("Computer is Turned Off.[Implementation]");
        }
        public void Restart()
        {
            Console.WriteLine("Computer is Restarted.");
        }
        //Explicit Implementation
        void Idevice.TurnOn()
        {
            Console.WriteLine("Computer is Turned On.[Interface]");
        }
        void Idevice.TurnOff()
        {
            Console.WriteLine("Computer is Turned Off.[Interface]");
        }
    }
}
