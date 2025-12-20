using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Professor : Person
    {
        public string ProfessorId { get; set; }

        public string Subject { get; set; }

        public override string GetDetails()
        {
            return $"Professor Name : {Name}, Age : {Age}, ProfessorId : {ProfessorId}, Subject : {Subject}";
        }
    }
}
