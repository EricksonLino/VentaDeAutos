using VentaDeAutos.Entity;

namespace VentaDeAutos.Repository.Interfaces
{
    public interface IAutoCedanRepository
    {
        Task<List<AutoCedan>> ListarAutos();
    }
}
