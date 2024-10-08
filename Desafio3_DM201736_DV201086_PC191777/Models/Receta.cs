using System.ComponentModel.DataAnnotations;

namespace Desafio3_DM201736_DV201086_PC191777.Models
{
    public class Receta
    {

        public int Id { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Range(1, 240)]
        public int TiempoPreparacion { get; set; } // Tiempo en minutos

      
    }
}
