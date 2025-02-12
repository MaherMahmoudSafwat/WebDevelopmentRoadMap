using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Man
    {
        public Man(string Name) 
        {
            Console.WriteLine("Hello, World!");
            this.Name = Name;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
