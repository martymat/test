using System;
using System.Collections.Generic;
using System.Text;

namespace scrap.rockstar.movie_theater_booking_service
{
    class Movie : IMovie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }
    }
}
