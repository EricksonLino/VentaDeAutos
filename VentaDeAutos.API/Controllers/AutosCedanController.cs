using Microsoft.AspNetCore.Mvc;
using VentaDeAutos.Application.Dtos;
using VentaDeAutos.Application.Interfaces;

namespace VentaDeAutos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutosCedanController : ControllerBase
    {
        private readonly IAutoCedanApplication autoCedanApplication;

        public AutosCedanController(IAutoCedanApplication autoCedanApplication)
        {
            this.autoCedanApplication = autoCedanApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<AutoCedanDto>>> ListarAutos()
        {
            var autoscedan = await this.autoCedanApplication.ListarAutos();
            return autoscedan;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AutoCedanDetalleDto>> ObtenerAuto(int id)
        {
            var autocedan = await this.autoCedanApplication.ObtenerAuto(id);
            if (autocedan == null)
            {
                return NotFound($"No se encontro el Auto con ID {id}");
            }
            return autocedan;
        }

    }
}
