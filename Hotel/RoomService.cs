using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class RoomService
    {
        internal void CleanRoom(RoomForTwo r)
        {
            r.IsClean();
            Console.WriteLine($"Room with {r.GetFeatures()} has been cleaned");

        }
        internal void CleanRoom(FamilyRoom r)
        {
            r.IsClean();
            Console.WriteLine($"Room with {r.GetFeatures()} has been cleaned");
        }
        internal void CleanRoom(Suite r)
        {
            r.IsClean();
            Console.WriteLine($"Room with {r.GetFeatures()} has been cleaned");
        }
    }
}
