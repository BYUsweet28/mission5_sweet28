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
        public DbSet<Category> Categories { get; set; }

        //Seed Data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure"},
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 7, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 8, CategoryName = "Televeision" },
                new Category { CategoryID = 9, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 10, CategoryName = "VHS" }
                );

            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    CategoryID = 1,
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
                    CategoryID = 2,
                    Title = "Home Alone",
                    Year = 1990,
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = true
                },
                new MovieResponse
                {
                    MovieId = 3,
                    CategoryID = 3,
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
