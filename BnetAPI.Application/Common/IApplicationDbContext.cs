using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BnetAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BnetAPI.Application.Common
{
    public interface IApplicationDbContext
    {
        DbSet<MovieInfo> MovieInfos { get; set; }

        DbSet<Genres> Genres { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
