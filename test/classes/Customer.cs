using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    class Customer : ICustomer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public decimal MoneyToSpend { get; set; }

        public List<IItemToPurchase> ItemsPurchased { get; set; }
    }
}
