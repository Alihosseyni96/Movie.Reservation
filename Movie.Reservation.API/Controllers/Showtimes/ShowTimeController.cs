using Application.Commont.BaseApiResponse;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.Reservation.API.Controllers.Showtimes.Mdoels;

namespace Movie.Reservation.API.Controllers.Showtimes
{
    [Route("api/showtimes")]
    [ApiController]
    public class ShowTimeController : ControllerBase
    {
        private readonly IShowTimeService _service;

        public ShowTimeController(IShowTimeService service)
        {
            _service = service;
        }

        [HttpPost("{Id}/tickets")]
        public async Task<ActionResult<ApiResponse<object>>> ReserveTicketAsync([FromRoute]Guid Id,[FromBody] ReserveTicketRequest  request , CancellationToken cancellationToken)
        {
            await _service.AddTicketAsync(Id, request.PhoneNumber);

            return Ok(ApiResponse<object>.Success(null));
        }

    }
}
