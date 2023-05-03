using VentaDeAutos.Entity;

namespace VentaDeAutos.Application.Interfaces
{
    public interface IAutoCedanApplication 
    {
        Task<List<AutoCedan>> ListarAutos();
    }
}
