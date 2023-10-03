using scrap.rockstar.movie_theater_booking_service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviesPlayingNow = CreateMovies();
            var ticketsAvailable = CreateTickets();

            var customer = new Customer { CustomerId = 1, Name = "Bradley Beal", MoneyToSpend = 100.00m, ItemsPurchased = null };
            var customerMovieTicketWanted = ticketsAvailable.Where(x => x.MovieId == 3).FirstOrDefault();

            // bradley beal
            // books iron man
            var bookingService = new Booking();
            var ableToBook = bookingService.BookMovie(customer, customerMovieTicketWanted, 2);

            if (ableToBook)
            {
                Console.WriteLine(customer.Name + " has booked movie " +
                    moviesPlayingNow.Where(x => x.Id == customerMovieTicketWanted.MovieId).FirstOrDefault().Name +
                    " successfully!");
            }
        }

        static List<IMovie> CreateMovies()
        {
            var movies = new List<IMovie>
            {
                new Movie { Id = 1, Name = "Frankenstein", Duration = 128 },
                new Movie { Id = 2, Name = "Up", Duration = 99 },
                new Movie { Id = 3, Name = "Iron Man", Duration = 108 },
                new Movie { Id = 4, Name = "Spirited Away", Duration = 112 },
            };

            return movies;
        }

        static List<IMovieTickets> CreateTickets()
        {
            var tickets = new List<IMovieTickets>
            {
                new MovieTickets { ItemId = 101, ItemPrice = 21.99m, ItemQuantity = 100, ItemType = ItemType.MovieTicket, MovieId = 1, Theater = 1 },
                new MovieTickets { ItemId = 102, ItemPrice = 12.99m, ItemQuantity = 50, ItemType = ItemType.MovieTicket, MovieId = 2, Theater = 2 },
                new MovieTickets { ItemId = 103, ItemPrice = 13.99m, ItemQuantity = 50, ItemType = ItemType.MovieTicket, MovieId = 3, Theater = 3 },
                new MovieTickets { ItemId = 104, ItemPrice = 14.99m, ItemQuantity = 25, ItemType = ItemType.MovieTicket, MovieId = 4, Theater = 4 },
            };

            return tickets;
        }
    }
}
