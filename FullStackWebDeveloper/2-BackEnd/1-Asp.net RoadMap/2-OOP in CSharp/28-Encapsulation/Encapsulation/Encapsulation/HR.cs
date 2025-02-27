using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Encapsulation
{
    class HR
    {
        //The point of Encapsulation is to avoid invalid inputs.
        /* 
         Encapsulation - Explanation & Purpose
         🔹 Encapsulation is one of the core principles of Object-Oriented Programming(OOP). It refers to the practice of hiding the internal details of an object and only exposing controlled access through methods.

         🔹 It helps in protecting data from direct modification, ensuring that only allowed operations are performed on it.

         🔹 The main goal of encapsulation is to achieve data security, maintainability, and modularity in a program.

         🔹 It allows developers to enforce rules and validation when accessing or modifying data, preventing unintended or harmful changes.

         🔹 Encapsulation improves code organization by grouping related data (attributes) and behaviors (methods) inside a single unit (class).
         */
        //The point of Encapsulation is to avoid invalid inputs.
         public string FirstName { get; private set; }
         public string LastName { get;private set; }
         public void SetName(string FirstName,string LastName)
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
        public int TaxSalary { set; get; }
        public void SetDateBirth(DateOnly BirthDate)
        {
            if (BirthDate < new DateOnly(1986, 7, 1))
                throw new ArgumentException("Invalid date");
            this.BirthDate = BirthDate;
        }
    }
}
