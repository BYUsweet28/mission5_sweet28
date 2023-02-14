using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Comedy",
                    Title = "Napoleon Dynamite",
                    Year = 2004,
                    Director = "Jared Hess",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Max",
                    Notes = "Filmed in Idaho"
                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Family",
                    Title = "Home Alone",
                    Year = 1990,
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = true
                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Action/Adventure",
                    Title = "Jurrasic Park",
                    Year = 1993,
                    Director = "Steven Speilberg",
                    Rating = "PG-13",
                    Edited = true,
                    Notes = "Watch out for velociraptors"
                }
                );
        }
    }
}
