using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class IntentEmployee:Employee
    {
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return 2000;
        }
    }
}
