using VentaDeAutos.Entity;

namespace VentaDeAutos.Repository.Interfaces
{
    public interface IAutoCedanRepository
    {
        Task<List<AutoCedan>> ListarAutos();
        Task<AutoCedan> ObtenerAuto(int id);
        Task InsertarAutoCedan(AutoCedan autoCedan);
        Task EliminarAutoCedan(AutoCedan autoCedan);
    }
}
