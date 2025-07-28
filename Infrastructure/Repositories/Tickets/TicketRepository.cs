using Domain.Entities.Tickets;
using Domain.IRepositories.Tickets;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Tickets
{
    public class TicketRepository : BaseRepository<Ticket> , ITicketRepository
    {
        public TicketRepository(MovieReservationContext context) : base(context)
        {
            
        }
    }
}
