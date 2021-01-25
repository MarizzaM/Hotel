using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class FamilyRoom : Room
    {
        public FamilyRoom(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            Console.WriteLine("Bed, TV, mini bar, cupboard,sofa, table, chairs");
        }

        protected override void SetPrice()
        {
            price = 100f;
            bool summerSeason = true;
            if (summerSeason)
            {
                this.price = price + price / 2;
            }
            else
            {
                this.price = price;
            }
            Console.WriteLine($"Price: {this.price} $");
        }
    }
}
