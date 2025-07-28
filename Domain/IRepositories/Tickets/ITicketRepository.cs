using Domain.Entities.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories.Tickets
{
    public interface ITicketRepository : IRepository<Ticket>
    {
    }
}
