using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Model
{
    public class MovieDb : DbContext
    {
        public MovieDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<FavMovie> MovieTable { get; set; }

        public DbSet<Login> Logins { get; set; }
    }
}
