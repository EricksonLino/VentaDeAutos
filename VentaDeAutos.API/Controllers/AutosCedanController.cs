using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaDeAutos.Application.Interfaces;
using VentaDeAutos.Entity;

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
        public async Task<ActionResult<List<AutoCedan>>> ListarAutos()
        {
            var autoscedan = await this.autoCedanApplication.ListarAutos();
            return autoscedan;
        }

    }
}
