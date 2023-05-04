using VentaDeAutos.Application.Interfaces;
using VentaDeAutos.Entity;
using VentaDeAutos.Repository.Interfaces;

namespace VentaDeAutos.Application.Implementaciones
{
    public class AutoCedanApplication : IAutoCedanApplication
    {
        private readonly IAutoCedanRepository autoCedanRepository;

        public AutoCedanApplication(IAutoCedanRepository autoCedanRepository)
        {
            this.autoCedanRepository = autoCedanRepository;
        }
        public async Task<List<AutoCedan>> ListarAutos()
        {
            var autoscedan = await this.autoCedanRepository.ListarAutos();
            return autoscedan;
        }

        public async Task<AutoCedan> ObtenerAuto(int id)
        {
            var AutoCedan = await this.autoCedanRepository.ObtenerAuto(id);
            return AutoCedan;
        }
    }
}
