using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student1
    {
        //You can't access private members or private methods outside class scope. 
        private string name { set; get; }
        public int id { set; get; }
    }
    public class Student2
    {
        //Public members is accessed from everywhere in any project.  
        public string name { set; get; }
        internal int id { set; get; }
        //Private members only is accessed inside the class scope.
        private class NestedStudentClass
        {
            public string Address { set; get; }
        }
        NestedStudentClass C1 = new NestedStudentClass();
        public void SetAddress()
        {
            NestedStudentClass C1 = new NestedStudentClass();
            C1.Address = "123 Main St";  // Setting the Address
            Console.WriteLine(C1.Address);  // Accessing the Address
        }
    }
}
