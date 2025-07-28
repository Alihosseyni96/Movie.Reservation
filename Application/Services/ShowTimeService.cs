using Domain.Common.Exceptions;
using Domain.IRepositories;
using Domain.IRepositories.ShowTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ShowTimeService : IShowTimeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShowTimeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddTicketAsync(Guid id, string phoneNumber)
        {

            var showTime = await _unitOfWork.ShowTime.GetByIdAsync(
                predicate : x=> x.Id == id ,
                includes : new Expression<Func<Domain.Entities.Showtimes.Showtime, object>>[] {x=> x.Tickets , x=> x.Auditorium}
                );

            if (showTime is null)
                throw new NotFoundException("selected show time not found");

            showTime.CapacityChecked();

            showTime.AddTicket(phoneNumber);

            await _unitOfWork.SaveChangesAsync();

        }
    }
}
