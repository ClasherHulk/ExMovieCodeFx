using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExCoreWebAPICODEFx.Models;

namespace ExCoreWebAPICODEFx.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<ExCoreWebAPICODEFx.Models.Movie> Movie { get; set; }
    }
}
