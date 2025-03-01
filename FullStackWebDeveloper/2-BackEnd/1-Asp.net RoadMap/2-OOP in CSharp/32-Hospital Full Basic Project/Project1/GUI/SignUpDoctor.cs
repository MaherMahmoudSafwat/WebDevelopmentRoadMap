using HospitalFullProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Screen
{
    class SignUpDoctor
    {
        Person Person = new Staff();
        SignUpDoctor()
        {
            Random RDM = new Random();
            Person._ID = RDM.Next(100, 1000);
        }
        public static void SignUpStaffDoctor()
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
