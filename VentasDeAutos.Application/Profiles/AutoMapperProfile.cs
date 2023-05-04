using AutoMapper;
using VentaDeAutos.Application.Dtos;
using VentaDeAutos.Entity;

namespace VentaDeAutos.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AutoCedan, AutoCedanDetalleDto>();
            CreateMap<AutoCedan, AutoCedanDto>();

            CreateMap<AutoCedanCreacionDto, AutoCedan>();
        }
    }
}
