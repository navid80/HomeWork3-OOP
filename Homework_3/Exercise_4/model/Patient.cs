using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class Patient : Person
    {
        public int PatientId { get; set; }

        private List<string> _medicalHistory { get; set; }

        public Patient(string nationalId, string name, int age, int patientId) : base(nationalId, name, age)
        {
            PatientId = patientId;
            _medicalHistory = new List<string>();
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Patient Name : {Name}, Age : {Age}, NationalId : {NationalId}");
            Console.WriteLine("Medical History :");
            foreach (var item in _medicalHistory.Select((value, index) => new {index, value}))
            {
                Console.WriteLine($"{item.index + 1}- {item.value},");
            }
        }

        public void AddToMedicalHistory(string disease)
        {
            if (string.IsNullOrWhiteSpace(disease))
            {
                throw new Exception("Invalid Disease!");
            }
            _medicalHistory.Add(disease);
        }
    }
}
