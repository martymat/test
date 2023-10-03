using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    interface IItemToPurchase
    {
        int ItemId { get; set; }

        ItemType ItemType { get; set; }

        decimal ItemPrice { get; set; }

        int ItemQuantity { get; set; }
    }
}
