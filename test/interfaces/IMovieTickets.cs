using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    interface IMovieTickets : IItemToPurchase
    {
        int MovieId { get; set; }

        int Theater { get; set; }
    }
}
