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

        public async Task<AutoCedan> ObtenerAuto(int id)
        {
            var AutoCedan = await this.context.AutoCedans.FirstOrDefaultAsync(x => x.Id == id);
            return AutoCedan;
        }

        public async Task InsertarAutoCedan(AutoCedan autoCedan)
        {
            this.context.AutoCedans.Add(autoCedan);
            await this.context.SaveChangesAsync();
        }

        public async Task EliminarAutoCedan(AutoCedan autoCedan)
        {
            this.context.AutoCedans.Remove(autoCedan);
            await this.context.SaveChangesAsync();

        }
    }
}
