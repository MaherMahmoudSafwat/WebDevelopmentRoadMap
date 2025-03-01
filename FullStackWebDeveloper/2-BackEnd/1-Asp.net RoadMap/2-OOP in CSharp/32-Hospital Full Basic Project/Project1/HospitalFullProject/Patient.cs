using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFullProject
{
    class Patient : Person 
    {
        public string DiseaseType { set; get; }
        public override void SignUp()
        {
        }
    }
}
