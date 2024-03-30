using MediatR;
using StreamShare.Domain.Queries.Responses;

namespace StreamShare.Domain.Queries.Requests
{
    public class GetAllWeatherForecastRequest : IRequest<IEnumerable<GetAllWeatherForecastResponse>>
    {
    }
}
