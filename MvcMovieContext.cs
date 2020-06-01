using cw12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw12.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {

        }

        private DbSet<Movie> movie;

        public DbSet<Movie> GetMovie()
        {
            return movie;
        }

        public void SetMovie(DbSet<Movie> value)
        {
            movie = value;
        }
    }
}
