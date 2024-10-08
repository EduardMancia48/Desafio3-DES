using System.ComponentModel.DataAnnotations;

namespace Desafio3_DM201736_DV201086_PC191777.Models
{
    public class Preparacion
    {
        public int Id { get; set; }

        [Required, StringLength(500, MinimumLength = 10)]
        public string Descripcion { get; set; }

        [Range(1, 100)]
        public int StepOrder { get; set; }

        public int RecetaId { get; set; }
        public Receta Receta { get; set; }
    }
}
