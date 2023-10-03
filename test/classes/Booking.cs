using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    class Booking : IBooking
    {
        public bool BookMovie(ICustomer customer, IItemToPurchase itemToPurchase, int quantity)
        {
            if (itemToPurchase.ItemQuantity < quantity)
            {
                Console.WriteLine("Not enough tickets!");
                return false;
            }

            itemToPurchase.ItemQuantity -= quantity;

            customer.MoneyToSpend -= itemToPurchase.ItemPrice * quantity;
            customer.ItemsPurchased = new List<IItemToPurchase>();
            customer.ItemsPurchased.Add(itemToPurchase);

            return true;
        }
    }
}
