using Domain.IRepositories.ShowTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IShowTimeRepository ShowTime { get;  }

        Task<int> SaveChangesAsync();

    }
}
