using Exercise_4;
using System;
using System.Collections.Generic;

class Program
{
    public Patient GetNewPatientDetails()
    {
        Console.WriteLine("Enter Patient Id : ");
        int id = int.TryParse(Console.ReadLine(), out int x) ? x 
            : throw new Exception("Invalid Patient Id!");
        Console.WriteLine("Enter Patient NationalId : ");
        string nationalId = Console.ReadLine();
        Console.WriteLine("Enter Patient Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Patient Age : ");
        int age = int.TryParse(Console.ReadLine(), out int a) ? a
            : throw new Exception("Invalid Patient Age!"); ;

        return new Patient(nationalId, name, age, id);
    }

    public Patient FindPatient(List<Patient> patients)
    {
        foreach (var patient in patients)
        {
            Console.WriteLine($"{patient.PatientId} : {patient.Name}");
        }
        Console.WriteLine("Enter Patient Id : ");
        int patientId = int.TryParse(Console.ReadLine(), out int x) ? x
            : throw new Exception("Invalid Patient Id!");
        Patient foundPatient = patients.FirstOrDefault(p => p.PatientId == patientId) 
            ?? throw new Exception("Patient Was Not Found");
        return foundPatient;
    }

    public Doctor FindDoctor(List<Doctor> doctors)
    {
        foreach (var doctor in doctors)
        {
            Console.WriteLine($"{doctor.DoctorId} : {doctor.Name}");
        }
        Console.WriteLine("Enter Doctor Id : ");
        int doctorId = int.TryParse(Console.ReadLine(), out int x) ? x
            : throw new Exception("Invalid Doctor Id!");
        Doctor foundDoctor = doctors.FirstOrDefault(d => d.DoctorId == doctorId)
            ?? throw new Exception("Doctor Was Not Found"); ;
        return foundDoctor;
    }

    static void Main()
    {
        Program program = new Program();
        Hospital hospital = Hospital.Instance;

        hospital.HospitalRooms.Add(new Room (101,2));
        hospital.HospitalRooms.Add(new Room (102,2));
        hospital.HospitalRooms.Add(new Room (103,6));
        hospital.HospitalRooms.Add(new Room (104,4));

        DoctorFactory doctorFactory_1 = new DoctorFactory("Dr.Ahmadi", 56, "0926598741", 5005, "Cardiology", new CardiologyDiagnosis());
        hospital.DoctorsList.Add(doctorFactory_1.CreatePerson());
        DoctorFactory doctorFactory_2 = new DoctorFactory("Dr.Amini", 39, "09265596741", 5006, "Neurology", new NeurologistsDiagnosis());
        hospital.DoctorsList.Add(doctorFactory_2.CreatePerson());
        DoctorFactory doctorFactory_3 = new DoctorFactory("Dr.Sadeghi", 43, "09365496741", 5007, "General", new GeneralDiagnosis());
        hospital.DoctorsList.Add(doctorFactory_3.CreatePerson());

        PatientFactory patientFactory_1 = new PatientFactory("Sara", 23, "0923658974", 54);
        PatientFactory patientFactory_2 = new PatientFactory("Ali", 52, "0923634433", 67);
        PatientFactory patientFactory_3 = new PatientFactory("Reza", 17, "0923654554", 69);

        hospital.AdmitPatient(patientFactory_1.CreatePerson());
        hospital.AdmitPatient(patientFactory_2.CreatePerson());
        hospital.AdmitPatient(patientFactory_3.CreatePerson());

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1- Admit a Patient");
            Console.WriteLine("2- Discharge a Patient");
            Console.WriteLine("3- Show Patient Details");
            Console.WriteLine("4- Show Doctor Details");
            Console.WriteLine("5- Disease Diagnose");
            Console.WriteLine("0- Exit");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Choose An Option :");
            string input = Console.ReadLine();
            int choice;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                Console.Write("Press any key to return to the menu");
                Console.ReadKey();
                continue;
            }
            try
            {
                switch (choice)
                {
                    case 1:
                        Patient newPatient = program.GetNewPatientDetails();
                        hospital.AdmitPatient(newPatient);
                        Console.Write("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Patient dischargedPatient = program.FindPatient(hospital.patientsList);
                        hospital.DischargePatient(dischargedPatient);
                        Console.Write("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Patient foundPatient = program.FindPatient(hospital.patientsList);
                        foundPatient.GetDetails();
                        Console.Write("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Doctor foundDoctor = program.FindDoctor(hospital.DoctorsList);
                        foundDoctor.GetDetails();
                        Console.Write("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Doctor doctor = program.FindDoctor(hospital.DoctorsList);
                        Patient patient = program.FindPatient(hospital.patientsList);
                        doctor.Diagnose(patient);
                        Console.Write("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 0:
                        exit = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Write("Press any key to return to the menu");
                Console.ReadKey();
            }
        }

    }
}
