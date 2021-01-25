using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    static class Reception
    {
        private const int NUMBERS_OF_ROOMS = 101;
        private static int numberOfGuiest;
        private static Room[] rooms = new Room[NUMBERS_OF_ROOMS];
        private static RoomService roomService;
        public static void SetRooms()
        {
            for (int i = 0; i < NUMBERS_OF_ROOMS; i++)
            {
                if (i < 33)
                    rooms[i] = new RoomForTwo(i, 50);
                else if (i < 66)
                    rooms[i] = new FamilyRoom(i, 50);
                else
                    rooms[i] = new Suite(i, 50);
            }
        }
        public static Room CheckIn(Guest g) {
            Console.WriteLine($"Hello, {g.GetName()}");
            for (int i = 0; i < NUMBERS_OF_ROOMS; i++) {
                if (rooms[i] != null) {
                    rooms[i].SetGuest(g);
                    numberOfGuiest++;
                    numberOfGuiest = i;
                    break;
                }
            }
            return rooms[numberOfGuiest];
        }

        public static void CheckOut(Room r) {
            r.SetGuest(null);
            SendRoomService(r);
            numberOfGuiest--;
        }

        public static bool IsRoomFree(Room r) {
            if (r.GetGuest() == null)
            {
                return true;
            }
            else {
                return false;
            }
        }
        private static void SendRoomService(Room r) {
            if (r.GetPrice() == 50) { roomService.CleanRoom((RoomForTwo)r); }
            if (r.GetPrice() == 100) { roomService.CleanRoom((Suite)r); }
            if (r.GetPrice() == 150) { roomService.CleanRoom((FamilyRoom)r); }
        }
    }
}
