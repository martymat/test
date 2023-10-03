using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    class MovieTickets : IMovieTickets
    {
        public int ItemId { get; set; }

        public ItemType ItemType { get; set; }

        public decimal ItemPrice { get; set; }

        public int ItemQuantity { get; set; }

        public int MovieId { get; set; }

        public int Theater { get; set; }
    }
}
