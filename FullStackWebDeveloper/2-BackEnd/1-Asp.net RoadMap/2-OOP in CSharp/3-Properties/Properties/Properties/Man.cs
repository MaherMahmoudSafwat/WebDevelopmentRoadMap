using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Man
    {
        //Constructor is the only place where you can assign a value to the Read-Only Property.  
        public Man(int id) 
        {
            ID = id;
        }
        //public string Name { get; set; } //Auto-Implemented Property.  
        /*public void setName(string name)
        {
             Name = name;
        }
        public string getName()
        {
            return Name;
        }*/

        //Backing Field.
        private string _name;
        public string Name
        {
            set
            {
                if (value.Length > 5)
                    return;
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        //Read-Only Property
        public int ID { get;}
        /* public void setID(int id)
        {
            ID = id;
        }*///Not Allowed because ID is Read-Only Property. 
        public string Address { get; init; }
    }
}
