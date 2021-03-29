using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BnetAPI.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace BnetAPI.Infrastructure.Models
{
    public class BnetDbContext:DbContext
    {
        public BnetDbContext(DbContextOptions<BnetDbContext>options):base(options)
        {
            
        }

        public DbSet<MovieInfo> MovieInfos { get; set; }
        public DbSet<Genres> Genres { get; set; }
    }
}
