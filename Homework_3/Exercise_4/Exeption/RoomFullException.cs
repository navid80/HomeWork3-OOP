using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class RoomFullException : Exception
    {
        public int RoomNumber { get; set; }

        public RoomFullException(int roomNumber)
            : base($"Room Number {roomNumber} Is Full!")
        {
            RoomNumber = roomNumber;
        }
    }
}
