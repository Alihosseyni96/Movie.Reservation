using Domain.Common.Exceptions;


namespace Domain.Entities.Showtimes.Exceptions
{
    public class ShowtimeCapacityExceededException : AppException
    {
        public ShowtimeCapacityExceededException()
            : base("No more seats available for this showtime.") { }

        public override int StatusCode => 409;
    }
}
