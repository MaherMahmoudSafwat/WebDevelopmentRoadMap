using HospitalFullProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Screen
{
    class SignUpPatient
    {
        Person Person = new Staff();
        SignUpPatient()
        {
            Random RDM = new Random();
            Person._ID = RDM.Next(10000, 100000);
        }
        public static void SignUpStaffPatient()
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
