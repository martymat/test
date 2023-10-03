using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    interface IPurchaseItem
    {
        IItemToPurchase ItemToPurchase { get; set; }

        int ItemToPurchaseQuantity { get; set; }
    }
}
