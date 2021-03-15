using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerCsharp
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public string FullName { get; set; }

        public void CreateFullName()
        {
            FullName= FirstName + " " + LastName;
        }

        public string GetFullName()
        {
            string result = string.Empty;
            result=FirstName + " " + LastName;
            return result;
        }


    }
}
