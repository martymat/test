using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    interface IMovie
    {
        int Id { get; set; }

        string Name { get; set; }

        int Duration { get; set; }
    }
}
