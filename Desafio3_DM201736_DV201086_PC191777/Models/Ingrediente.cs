using System.ComponentModel.DataAnnotations;

namespace Desafio3_DM201736_DV201086_PC191777.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Range(1, 10000)]
        public double Cantidad { get; set; }

        [Required]
        public string Unidad { get; set; } // Gramos, Litros, etc.

        public int RecetaId { get; set; }
        public Receta Receta { get; set; }
    }
}
