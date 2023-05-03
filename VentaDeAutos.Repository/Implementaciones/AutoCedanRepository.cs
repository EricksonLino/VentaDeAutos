using Microsoft.EntityFrameworkCore;
using VentaDeAutos.Entity;
using VentaDeAutos.Repository.Interfaces;

namespace VentaDeAutos.Repository.Implementaciones
{
    public class AutoCedanRepository : IAutoCedanRepository
    {
        private readonly ApplicationDbContext context;

        public AutoCedanRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<AutoCedan>> ListarAutos()
        {
            var autosCedan = await this.context.AutoCedans.ToListAsync();
            return autosCedan;
        }
    }
}
