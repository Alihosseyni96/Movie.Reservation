using Application.Commont.BaseApiResponse;
using Domain.Common.Exceptions;
using System.Text.Json;

namespace Movie.Reservation.API.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (AppException ex)
            {

                context.Response.StatusCode = ex.StatusCode;
                context.Response.ContentType = "application/json";
                
                await context.Response.WriteAsJsonAsync(new ApiResponse<string>
                {
                    IsSucess = false,
                    Data = null,
                    Errors = new List<string> { ex.Message }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled Exception");
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(new ApiResponse<string>
                {
                    IsSucess = false,
                    Data = null,
                    Errors = new List<string> { ex.Message }
                });
            }
        }
    }
}
