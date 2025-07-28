using Domain.Entities.Auditoriums;
using Domain.Entities.Movies;
using Domain.Entities.Showtimes.Exceptions;
using Domain.Entities.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Showtimes
{
    public class Showtime : EntityBase<Guid>
    {

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int AuditoriumId { get; set; }
        public Auditorium Auditorium { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public bool IsFilled { get; set; }
        public int ResearvedSeats { get; set; }

        public void CapacityChecked()
        {
            if (IsFilled)
                throw new ShowtimeCapacityExceededException();

        }

        public void AddTicket(string phoneNumber)
        {
            Tickets.Add(new Ticket(phoneNumber, Id));

            ResearvedSeats++;
            if(ResearvedSeats >= Auditorium.Capacity)
                IsFilled = true;
        }

    }
}
