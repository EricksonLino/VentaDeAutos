using System.ComponentModel.DataAnnotations;

namespace VentaDeAutos.Application.Dtos
{
    public class AutoCedanCreacionDto
    {
        [Required]
        [StringLength(50)]
        public string Marca { get; set; }
        [Required]
        [StringLength(30)]
        public string color { get; set; }
        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Required]
        [StringLength(50)]
        public string Transmición { get; set; }
        [Required]
        [StringLength(50)]
        public string TipoDeFrenos { get; set; }
        [Required]
        [StringLength(30)]
        public string Capacidad { get; set; }
        [Required]
        public int Stock { get; set; }
    }
}
