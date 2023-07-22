using AutoMapper;
using MediatR;
using StreamShare.Domain.Entities;
using StreamShare.Domain.Queries.Requests;
using StreamShare.Domain.Queries.Responses;

namespace StreamShare.Application.Queries
{
    public class GetAllWeatherForecastQueryHandler : IRequestHandler<GetAllWeatherForecastRequest, IEnumerable<GetAllWeatherForecastResponse>>
    {
        private readonly IMapper _mapper;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public GetAllWeatherForecastQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAllWeatherForecastResponse>> Handle(GetAllWeatherForecastRequest _, CancellationToken cancellationToken)
        {
            await Task.Delay(1000, cancellationToken);
            return _mapper.Map<IEnumerable<WeatherForecast>, IEnumerable<GetAllWeatherForecastResponse>>(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }));
        }
    }
}
