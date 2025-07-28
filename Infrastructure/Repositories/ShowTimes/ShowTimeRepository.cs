using Domain.Entities.Showtimes;
using Domain.IRepositories.ShowTime;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.ShowTimes
{
    public class ShowTimeRepository : BaseRepository<Showtime> , IShowTimeRepository
    {
        public ShowTimeRepository(MovieReservationContext context) : base(context)
        {
            
        }
    }
}
