using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public abstract class Person
    {
        public string NationalId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string nationalId, string name, int age)
        {
            NationalId = nationalId;
            Name = name;
            Age = age;
        }

        public abstract void GetDetails();
    }
}
