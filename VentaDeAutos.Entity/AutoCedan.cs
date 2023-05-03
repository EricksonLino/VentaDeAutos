using System.ComponentModel.DataAnnotations;

namespace VentaDeAutos.Entity
{
    public class AutoCedan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Marca { get; set; }
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
        [StringLength(50)]
        public int Stock { get; set; }

    }
}
