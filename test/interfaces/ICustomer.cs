using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    interface ICustomer
    {
        int CustomerId { get; set; }

        string Name { get; set; }

        decimal MoneyToSpend { get; set; }

        List<IItemToPurchase> ItemsPurchased { get; set; }
    }
}
