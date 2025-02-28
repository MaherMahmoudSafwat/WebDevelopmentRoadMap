using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class HourlyEmployee : Employee
    {
        public decimal HourRate { set; get; }
        public int TotalWorkingHours { set; get; }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return HourRate + TotalWorkingHours;
        }
    }
}