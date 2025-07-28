using Domain.IRepositories;
using Domain.IRepositories.ShowTime;
using Infrastructure.Context;
using Infrastructure.Repositories.ShowTimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieReservationContext _context;
        public IShowTimeRepository ShowTime { get; }

        public UnitOfWork(MovieReservationContext context)
        {
            _context = context;
            ShowTime = new ShowTimeRepository(context);
        }

        public async Task<int> SaveChangesAsync()
        {
           return  await _context.SaveChangesAsync();
        }

        public async void Dispose() => await _context.DisposeAsync();
        
    }
}
