using Domain.IRepositories;
using Domain.IRepositories.ShowTime;
using Domain.IRepositories.Tickets;
using Infrastructure.Repositories;
using Infrastructure.Repositories.ShowTimes;
using Infrastructure.Repositories.Tickets;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DependencyInjection
{
    public static class RepositoryServiceRegistration
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
