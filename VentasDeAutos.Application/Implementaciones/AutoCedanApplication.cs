using AutoMapper;
using VentaDeAutos.Application.Dtos;
using VentaDeAutos.Application.Interfaces;
using VentaDeAutos.Entity;
using VentaDeAutos.Repository.Interfaces;

namespace VentaDeAutos.Application.Implementaciones
{
    public class AutoCedanApplication : IAutoCedanApplication
    {
        private readonly IAutoCedanRepository autoCedanRepository;
        private readonly IMapper mapper;

        public AutoCedanApplication(IAutoCedanRepository autoCedanRepository, IMapper mapper)
        {
            this.autoCedanRepository = autoCedanRepository;
            this.mapper = mapper;
        }

        public async Task<List<AutoCedanDto>> ListarAutos()
        {
            var autoscedan = await this.autoCedanRepository.ListarAutos();
            var autoCedanDto = this.mapper.Map<List<AutoCedanDto>>(autoscedan);
            return autoCedanDto;
        }

        public async Task<AutoCedanDetalleDto> ObtenerAuto(int id)
        {
            var autocedan = await this.autoCedanRepository.ObtenerAuto(id);
            var autoCedanDetalleDto = this.mapper.Map<AutoCedanDetalleDto>(autocedan);

            return autoCedanDetalleDto;
        }

        public async Task InsertarAutoCedan(AutoCedanCreacionDto autoCedanCreacionDto)
        {
            var autocedan = this.mapper.Map<AutoCedan>(autoCedanCreacionDto);
            await this.autoCedanRepository.InsertarAutoCedan(autocedan);
        }

        public async Task EliminarAutoCedan(int id)
        {
            var autocedan = await this.autoCedanRepository.ObtenerAuto(id);
            await this.autoCedanRepository.EliminarAutoCedan(autocedan);
        }
    }
}
