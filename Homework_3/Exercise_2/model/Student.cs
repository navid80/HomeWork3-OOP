using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Student : Person
    {
        public string StudentId { get; set; }

        public string Major { get; set; }

        public override string GetDetails()
        {
            return $"Student Name : {Name}, Age : {Age}, StudentID : {StudentId}, Major : {Major}";
        }
    }
}
