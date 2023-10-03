using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    class PurchaseItem : IPurchaseItem
    {
        public IItemToPurchase ItemToPurchase { get; set; }

        public int ItemToPurchaseQuantity { get; set; }

        public PurchaseItem(IItemToPurchase item, int quantity)
        {
            ItemToPurchase = item;
            ItemToPurchaseQuantity = quantity;
        }
    }
}
