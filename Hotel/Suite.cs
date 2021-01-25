using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Suite : Room
    {
        public Suite(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            Console.WriteLine("Bed, TV, mini bar, cupboard,sofa, table, chairs, jacuzzi");
        }

        protected override void SetPrice()
        {
            price = 150f;
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
