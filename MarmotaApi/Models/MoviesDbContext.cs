using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarmotaApi;
using Microsoft.EntityFrameworkCore;

namespace MarmotaApi.Models
{
    public class ConexaoDbContext
    {
        public class MoviesDbContext : DbContext
        {
            public DbSet<Movie> Movies { get; set; }
            public List<Movie> Movie { get; internal set; }

            public MoviesDbContext()
            {

            }

            public MoviesDbContext(DbContextOptions options) : base(options)
            {

            }
        }
    }
}
}
