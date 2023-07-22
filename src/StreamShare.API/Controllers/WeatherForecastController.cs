using MediatR;
using Microsoft.AspNetCore.Mvc;
using StreamShare.Domain.Queries.Requests;

namespace StreamShare.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult>  Get()
        {
            var response = await _mediator.Send(new GetAllWeatherForecastRequest());
            return Ok(response);
        }
    }
}