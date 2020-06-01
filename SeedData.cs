using cw12.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw12.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;   
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "test",
                        ReleaseDate = DateTime.Parse("2013-1-1"),
                        Genre = "Horror",
                        Rating = "7",
                        Price = 1M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
