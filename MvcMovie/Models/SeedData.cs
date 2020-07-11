using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Other Side of Heaven 2",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Biography",
                        Rating = "PG-13",
                        Price = 2.99M
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 2.99M
                    },

                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Love Kennedy",
                        ReleaseDate = DateTime.Parse("2017-6-2"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}