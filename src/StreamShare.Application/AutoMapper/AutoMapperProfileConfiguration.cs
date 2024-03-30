using AutoMapper;
using StreamShare.Domain.Entities;
using StreamShare.Domain.Queries.Responses;

namespace StreamShare.Application.AutoMapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() {

            CreateMap<WeatherForecast, GetAllWeatherForecastResponse>();

        }
    }
}
