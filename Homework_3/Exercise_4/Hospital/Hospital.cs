using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class Hospital
    {
        public List<Doctor> DoctorsList { get; set; }

        public List<Patient> patientsList = new List<Patient>();

        public List<Room> HospitalRooms { get; set; }

        private static Hospital _instance;

        public static Hospital Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Hospital();

                return _instance;
            }
        }

        private Hospital()
        {
            DoctorsList = new List<Doctor>();
            HospitalRooms = new List<Room>();
        }

        public void AdmitPatient(Patient patient)
        {
            if (patientsList.Contains(patient) || patientsList.Any(p => p.PatientId == patient.PatientId))
            {
                throw new Exception("This patient was registered before!");
            }

            Room emptyRoom = HospitalRooms.Where(r => r.PatientsInRoom.Count < r.Capacity).FirstOrDefault();
            
            if (emptyRoom == null)
            {
                throw new Exception("No Room Is Empty");
            }

            emptyRoom.AssignPatient(patient);
            patientsList.Add(patient);
        }

        public void DischargePatient(Patient patient)
        {
            Room patientRoom = HospitalRooms.Where(r => r.PatientsInRoom.Any(p => p.PatientId == patient.PatientId)).FirstOrDefault();
            if (patientRoom == null)
            {
                throw new Exception("No room matching this patient’s details was found. The operation cannot be performed.");
            }
            patientRoom.PatientsInRoom.Remove(patient);
            patientsList.Remove(patient);
        }
    }
}
