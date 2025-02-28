using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public void SetName(string FirstName, string LastName)
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                throw new Exception("Invalid Name");
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        //We used a private set to make the method be called by the method SetDateBirth and not from the auto-implemented method.
        public DateOnly BirthDate { private set; get; }
        /* {
             get
             {
                 return BirthDate;
             }
             set
             {
                 this.BirthDate = BirthDate;
             }
         }*///This is Allowed.
        public int BasicSalary { set; get; }
        public int TaxPercentage { set; get; }
        public void SetDateBirth(DateOnly BirthDate)
        {
            if (BirthDate < new DateOnly(1986, 7, 1))
                throw new ArgumentException("Invalid date");
            this.BirthDate = BirthDate;
        }
    }
}
