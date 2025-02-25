using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal
{
    // Allowed modifiers for class : public, internal, or abstract/sealed/static combined with them.
    //Static methods can't be OverWrite/overriden.
    public class Shapes
    {
        // The 'protected internal' access modifier allows access to a member within the same assembly (internal) 
        // and from derived classes, even if they are in a different assembly (protected).

        // This means that members marked as 'protected internal' can be accessed by:
        // 1. Any class within the same project/assembly (like 'internal').
        // 2. Any derived class, even if it exists in another project/assembly (like 'protected').

        // If a class is in a different assembly but does not inherit from the class containing the 'protected internal' member,
        // it cannot access the member.

        // 'protected internal' is useful when designing libraries or frameworks where some members should be accessible
        // within the project but also allow derived classes outside the project to use them.

        // It combines the benefits of both 'protected' and 'internal' to provide controlled access across assemblies.

        protected internal string Area = "100";
        /*protected private string x = "";
        protected public string m = "";*///Error This Are not a valid modifiers.

        /*
        Valid Access Modifiers in C#
        Modifier            Accessibility
        public	            Accessible from anywhere.
        private	            Accessible only within the same class.
        protected	        Accessible within the same class and derived classes.
        internal	        Accessible within the same assembly (project).
        protected internal	Accessible within same assembly + derived classes.
        private protected	Accessible within same class + derived classes in same assembly.
        */
    }
}
