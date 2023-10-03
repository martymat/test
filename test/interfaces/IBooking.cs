using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    interface IBooking
    {
        bool BookMovie(ICustomer customer, IItemToPurchase itemToPurchase, int quantity);
    }
}
