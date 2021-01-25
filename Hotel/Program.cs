using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest guestX = new Guest(1, "Mr. X");
            Room room = Reception.CheckIn(guestX);
            room = new Suite(1, 150);
            Console.WriteLine("Your room number is " + room.GetRoomNumber());
            Reception.CheckOut(room);
        }
    }
}
