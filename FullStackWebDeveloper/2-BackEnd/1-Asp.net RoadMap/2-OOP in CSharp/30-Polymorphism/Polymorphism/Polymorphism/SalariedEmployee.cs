using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SalariedEmployee : Employee
    {
        // Polymorphism allows methods to have different behaviors in derived classes.
        // It is achieved through method overriding and method overloading.

        // Method Overloading: Using the same method name with different parameters.
        // Method Overriding: A derived class provides a new implementation of a method from the base class.

        // A base class can have a virtual method that derived classes override.
        // Each derived class can implement the method differently while keeping the same method name.

        // Overloading allows multiple methods with the same name but different parameter types or counts.
        // This helps improve code readability and reusability.
        public decimal BasicSalary { set; get; }
        public decimal Transportation { set; get; }
        public decimal Housing { set; get; }
        public override decimal GetSalary()
        {
            return BasicSalary + Transportation + Housing;
        }
        //Static Polymorphism.
        public decimal GetSalary(int TaxPercentage)
        {
            return (GetSalary() * (BasicSalary + TaxPercentage / 100));
        }
    }
}
