using System;
using System.Collections.Generic;
using System.Text;
using BnetAPI.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BnetAPI.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BnetDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BnetConnection")));
            return services;
        }
    }
}
