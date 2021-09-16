using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movie.Models;

namespace movie.Data
{
    public class movieContext : DbContext
    {
        public movieContext (DbContextOptions<movieContext> options)
            : base(options)
        {
        }

        public DbSet<movie.Models.Movie> Movie { get; set; }
    }
}
