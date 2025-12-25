using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class Room
    {
        public int RoomNumber { get; set; }

        public int Capacity { get; set; }

        public List<Patient> PatientsInRoom { get; set; }

        public Room(int roomNumber, int capacity)
        {
            PatientsInRoom = new List<Patient>();
            RoomNumber = roomNumber;
            Capacity = capacity;
        }

        public void AssignPatient(Patient patient)
        {
            if (PatientsInRoom.Count >= Capacity)
            {
                throw new RoomFullException(RoomNumber);
            }

            if (patient == null)
            {
                throw new Exception("This patient is not registered in the system.");
            }

            PatientsInRoom.Add(patient);
        }
    }
}
