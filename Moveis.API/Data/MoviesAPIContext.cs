using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moveis.API.Model;

namespace Moveis.API.Data
{
    public class MoviesAPIContext : DbContext
    {
        public MoviesAPIContext (DbContextOptions<MoviesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Moveis.API.Model.Movie> Movie { get; set; }
    }
}
