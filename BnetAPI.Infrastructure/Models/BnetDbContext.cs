using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using BnetAPI.Application.Common;
using BnetAPI.Domain.Models;
using BnetAPI.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace BnetAPI.Infrastructure.Models
{
    public class BnetDbContext:DbContext,IApplicationDbContext
    {
        public BnetDbContext(DbContextOptions<BnetDbContext>options):base(options)
        {
            
        }
       public DbSet<MovieInfo> MovieInfos { get; set; }

       public DbSet<Genres> Genres { get; set; }

       public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
       {
           foreach (var entry in ChangeTracker.Entries<BaseEntity>())
           {
               switch (entry.State)
               {
                   case EntityState.Added:
                       entry.Entity.CreatedBy = _currentUserService.UserId;
                       entry.Entity.Created = DateTime.UtcNow;
                       break;
                   case EntityState.Modified:
                       entry.Entity.LastModifiedBy = _currentUserService.UserId;
                       entry.Entity.LastModified = DateTime.UtcNow;
                       break;
               }
           }

           return base.SaveChangesAsync(cancellationToken);
        }

    }
}
