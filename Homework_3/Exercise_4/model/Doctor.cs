using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class Doctor : Person
    {
        public int DoctorId { get; set; }

        public string Specialization { get; set; }

        private IDiagnosisStrategy _diagnosisStrategy;

        public Doctor(string nationalId, string name, int age, int doctorId, string specialization, IDiagnosisStrategy strategy) : base(nationalId, name, age)
        {
            DoctorId = doctorId;
            Specialization = specialization;
            _diagnosisStrategy = strategy ?? new GeneralDiagnosis();
        }

        public void Diagnose(Patient patient)
        {
            if (patient == null)
            {
                throw new Exception("This patient is not registered in the system.");
            }
            string diagnosis = _diagnosisStrategy.Diagnose();
            patient.AddToMedicalHistory(diagnosis);
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Doctor Name : {Name}, Age : {Age}, NationalId : {NationalId}, Specialization : {Specialization}");
        }
    }
}
