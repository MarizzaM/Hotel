using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hotel
{
    abstract class Room
    {
        protected int roomNumber;
        protected float price;
        protected Guest guest;
        protected bool isClean;
        protected string features;



        internal void SetGuest(Guest g) {
            this.guest = g;       
        }
        public Room(int roomNumber, float price)
        {
            this.roomNumber = roomNumber;
            this.price = price;
            SetPrice();
            SetFeatures();
        }


        protected virtual void SetPrice() {
            price = 50f;
            bool summerSeason = true;
            if (summerSeason)
            {
                this.price = price + price/2;
            }
            else {
                this.price = price;
            }
        }
        protected abstract void SetFeatures();

        public int GetRoomNumber() {
            return roomNumber;
        }
        public float GetPrice()
        {
            return price;
        }
        public Guest GetGuest()
        {
            return guest;
        }
        public bool IsClean()
        {
            return isClean;
        }
        public string GetFeatures()
        {
            return features;
        }

        public override string ToString()
        {
            return $"\n Room #{roomNumber} Price: {price} NIS" +
                $"\n Guest: {guest}\nIs clean? {isClean}\n Features in the room{features}";
        }
    }
}
