using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public abstract class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public abstract string GetDetails();
    }
}
