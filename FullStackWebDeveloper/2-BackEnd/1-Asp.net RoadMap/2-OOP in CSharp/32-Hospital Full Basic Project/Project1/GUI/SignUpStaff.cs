using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalFullProject;

namespace GUI
{
    class SignUpStaff
    {
        Person Person = new Staff();
        SignUpStaff()
        {
            Random RDM = new Random();
            Person._ID = RDM.Next(1, 10);
        }
        public static void SignUpStaffScreen()
        {
            Console.Clear();
            Person.SetName();
            Console.Clear();
            Person.SetEmail();
            Console.Clear();
            Person.SetPassword();
        }
    }
}
