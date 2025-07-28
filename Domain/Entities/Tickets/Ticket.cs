using Domain.Entities.Showtimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Tickets
{
    public class Ticket : EntityBase<Guid>
    {
        public Ticket(string phoneNumber, Guid showtimeId)
        {
            PhoneNumber = phoneNumber;
            ShowtimeId = showtimeId;
        }

        public Ticket()
        {
            
        }
        public string PhoneNumber { get; set; }
        public Guid ShowtimeId { get; set; }
        public Showtime Showtime { get; set; }
    }
}
