using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Screen
{
    class MainMenuScreen
    {
        private enum RoleStatus
        {
            Staff,
            Patient,
            Doctor
        }
        private static void StaffScreen()
        {

        }
        private static void PatientScreen()
        {

        }
        private static void DoctorScreen()
        {

        }
        public static void ShowMainMenu()
        {
            Console.WriteLine("\t\t\t\t\tWelcome to hospital Menu.");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Please choose one of your role status.");
            Console.WriteLine("1-Staff");
            Console.WriteLine("2-Patient");
            Console.WriteLine("3-Doctor");
            Console.WriteLine("---------------------------------------");
            string UserChoice = Console.ReadLine();
            RoleStatus Role = (RoleStatus)Enum.Parse(typeof(RoleStatus), UserChoice);
            switch(Role)
            {
                case RoleStatus.Staff:
                    StaffScreen();
                    break;
                case RoleStatus.Patient:
                    PatientScreen();
                    break;
                case RoleStatus.Doctor:
                    DoctorScreen();
                    break;
            }
        }
    }
}
